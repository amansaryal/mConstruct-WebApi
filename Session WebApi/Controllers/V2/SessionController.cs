using Grpc.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MobileWebApiLibrary;
using MobileWebApiLibrary.Action_Filters;
using MobileWebApiLibrary.Controllers;
using Session_WebApi.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Session_WebApi.Controllers.V2
{
    [ApiVersion("2")]
    //[Route("SessionApi/v{version:apiVersion}/")]
    [Route("SessionApi/v2/")]
    public class SessionController : BaseController
    {
        private readonly IConfiguration configuration;

        public SessionController(IConfiguration Configuration)
        {
            configuration = Configuration;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(GISStatusCodes.Status911UnsupportedAppVersion)]
        [Route("[action]")]
        [HttpPost]
        public ActionResult<UserSession> Login([FromBody] LoginRequest loginRequest)
        {
            if (string.IsNullOrEmpty(loginRequest.Username) || string.IsNullOrEmpty(loginRequest.Password))
                throw new HttpResponseException
                {
                    Status = StatusCodes.Status401Unauthorized,
                    Value = new ProblemDetails
                    {
                        Status = StatusCodes.Status401Unauthorized,
                        Instance = HttpContext.Request.Path.Value,
                        Title = "Empty username or password",
                        Detail = string.Format("Username is {0}", loginRequest.Username)
                    }
                };


            validateApp(loginRequest.AppName, loginRequest.AppVersion);

            //authenticate user
            AuthenticateUserInUMS(loginRequest.Username, loginRequest.Password);

            UserSession userSession = new UserSession();
            userSession.Username = loginRequest.Username;
            userSession.UmsDetails.Add((int)loginRequest.AppName, GetUmsData(GetUmsDataSet(loginRequest.Username, loginRequest.AppName), loginRequest.AppName));
            userSession.Token = GenerateToken(loginRequest.Username, loginRequest.AppName, loginRequest.Imei);

            return userSession;

        }

        private void AuthenticateUserInUMS(string username, string password)
        {
            Task<UmsService.AuthenticateUserResponse> authenticateUserResponse = new UmsService.UserProviderClient().AuthenticateUserAsync(new UmsService.AuthenticateUserRequest
            {
                userName = username,
                password = password
            });

            if (authenticateUserResponse.Result.AuthenticateUserResult == false)
            {
                throw new HttpResponseException
                {
                    Status = StatusCodes.Status401Unauthorized,
                    Value = new ProblemDetails
                    {
                        Status = StatusCodes.Status401Unauthorized,
                        Instance = HttpContext.Request.Path.Value,
                        Title = authenticateUserResponse.Result.dbError,
                        Detail = authenticateUserResponse.Result.dbError
                    }
                };
            }
        }

        private ActionResult<bool> validateApp(Appname appName, int appVersion)
        {
            //can not be noname
            //appname will default to noname in cases where a wrong appname is provided
            if (appName == Appname.Noname)
                throw new HttpResponseException
                {
                    Status = StatusCodes.Status400BadRequest,
                    Value = new ProblemDetails
                    {
                        Status = StatusCodes.Status400BadRequest,
                        Instance = HttpContext.Request.Path.Value,
                        Title = "Invalid application name",
                        Detail = "Either no app name was provided or a wrong name was provided."
                    }
                };

            //can not be 0
            if (appVersion == 0)
                throw new HttpResponseException
                {
                    Status = StatusCodes.Status400BadRequest,
                    Value = new ProblemDetails
                    {
                        Status = StatusCodes.Status400BadRequest,
                        Instance = HttpContext.Request.Path.Value,
                        Title = "Invalid application version",
                        Detail = "AppVersion can not be 0"
                    }
                };

            //get latest app version
            AppVersions.appVersionMappings.TryGetValue(appName, out int latestAppVersion);

            //if equal then it's valid
            if (appVersion == latestAppVersion)
                return true;

            throw new HttpResponseException
            {
                Status = StatusCodes.Status400BadRequest,
                Value = new ProblemDetails
                {
                    Status = GISStatusCodes.Status911UnsupportedAppVersion,
                    Instance = HttpContext.Request.Path.Value,
                    Title = "This app version is no longer supported. Please update the app",
                    Detail = string.Format("Provided appVersion = {0} is different than latest appVersion = {1}.", appVersion, latestAppVersion)
                }
            };

        }

        private DataSet GetUmsDataSet(string username, Appname appname)
        {
            UMSBindings.UmsAppUrlMap.TryGetValue(appname, out string appUrl);
            Task<UmsService.GetUserAppDetailsbyUserNameApplicationUrlResponse> response = new UmsService.UserProviderClient().GetUserAppDetailsbyUserNameApplicationUrlAsync(new UmsService.GetUserAppDetailsbyUserNameApplicationUrlRequest
            {
                userName = username,
                applicationUrl = appUrl
            });

            var result = response.Result.GetUserAppDetailsbyUserNameApplicationUrlResult;

            //create a data set from returned xelement list
            DataSet dataSet = new DataSet();

            //read schema 
            dataSet.ReadXmlSchema(new StringReader(result.Nodes[0].ToString()));
            //read data tables
            for (int i = 1; i < result.Nodes.Count; i++)
            {
                dataSet.ReadXml(new StringReader(result.Nodes[i].ToString()));
            }

            return dataSet;
        }

        private UMSData GetUmsData(DataSet umsDataSet, Appname appname = Appname.Noname)
        {
            //initialize returned ums data
            var umsData = new UMSData();
            umsData.Appname = appname;

            //get roles
            if (umsDataSet.Tables.Count == 4 && umsDataSet.Tables[3] != null)
            {
                for (int i = 0; i < umsDataSet.Tables[3].Rows.Count; i++)
                {
                    var userRole = umsDataSet.Tables[3].Rows[i]["SUBGROUP_NAME"].ToString();
                    umsData.Roles.Add(userRole);
                }
            }

            //get boundary code
            if (umsDataSet.Tables.Count == 4 && umsDataSet.Tables[2] != null)
            {
                for (int i = 0; i < umsDataSet.Tables[2].Rows.Count; i++)
                {
                    var boundaryCode = umsDataSet.Tables[2].Rows[i]["BOUNDARY_CODE"].ToString();
                    umsData.BoundaryCodes.Add(boundaryCode);
                }
            }

            return umsData;
        }

        private string GenerateToken(string username, Appname appname, string deviceID)
        {

            //generate session token
            var sessionToken = GenerateUniqueString();

            //remove stale session records if any
            FlushStaleSession(username, appname);

            //add new session to database
            if (!CreateNewSession(username, appname, deviceID, sessionToken))
            {
                //duplicate token encountered, generate new and try again
                CreateNewSession(username, appname, deviceID, sessionToken = GenerateUniqueString());
            }
            return sessionToken;
        }

        private string GenerateUniqueString()
        {
            char[] chars = new char[62];
            chars = configuration.GetValue<string>("chars").ToCharArray();

            byte[] data = new byte[1];
            int maxSize = configuration.GetValue<int>("maxSize");

            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder sb = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                sb.Append(chars[b % (chars.Length)]);
            }

            return sb.ToString();
        }

        private void FlushStaleSession(string username, Appname appname)
        {
            var context = new PlngDbContext();

            UMSBindings.BackwardsCompatibleAppnames.TryGetValue(appname, out string oldAppName);

            var records = context.Usersessioninfo
                .Where(user =>
                user.Userid.ToLower() == username.ToLower() &&
                 (
                 user.Appname.ToLower() == appname.ToString().ToLower() ||
                 user.Appname.ToLower() == oldAppName.ToLower()
                 )
                 ).ToList();

            if (records.Count > 0)
            {
                //remove
                records.RemoveAll(user => true);

                context.SaveChanges();
            }
        }

        public bool CreateNewSession(string username, Appname appname, string deviceID, string sessionToken)
        {
            var context = new PlngDbContext();

            try
            {
                //update old record and mark sesssion as active with the provided session token
                context.Usersessioninfo.Add(new Usersessioninfo
                {
                    Userid = username,
                    Appname = appname.ToString(),

                    Isactive = "Y",
                    Deviceid = deviceID,
                    Sessionkey = sessionToken
                });

                context.SaveChanges();
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message.Contains("unique constraint")) //this means that the session token already exists so retry
                    return false;
                else
                    throw ex;
            }


            return true;
        }
    }
}