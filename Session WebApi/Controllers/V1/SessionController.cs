using Grpc.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileWebApiLibrary;
using MobileWebApiLibrary.Action_Filters;
using MobileWebApiLibrary.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Session_WebApi.Controllers.V1
{
    [ApiVersion("1")]
    //[Route("SessionApi/v{version:apiVersion}/")]
    [Route("SessionApi/v1")]
    public class SessionController : BaseController
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(GISStatusCodes.Status911UnsupportedAppVersion)]
        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<UserSession>> Login([FromBody] LoginRequest loginRequest)
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
            await AuthenticateUserInUMS(loginRequest.Username, loginRequest.Password);

            ;

            UserSession userSession = new UserSession();
            userSession.Username = loginRequest.Username;
            userSession.UmsDetails.Add((int)loginRequest.AppName, await GetRoles(loginRequest.Username, loginRequest.AppName));

            return userSession;

        }

        private async Task AuthenticateUserInUMS(string username, string password)
        {
            UmsService.AuthenticateUserResponse authenticateUserResponse = await new UmsService.UserProviderClient().AuthenticateUserAsync(new UmsService.AuthenticateUserRequest
            {
                userName = username,
                password = password
            });

            if (authenticateUserResponse.AuthenticateUserResult == false)
            {
                throw new HttpResponseException
                {
                    Status = StatusCodes.Status401Unauthorized,
                    Value = new ProblemDetails
                    {
                        Status = StatusCodes.Status401Unauthorized,
                        Instance = HttpContext.Request.Path.Value,
                        Title = authenticateUserResponse.dbError,
                        Detail = authenticateUserResponse.dbError
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

        private async Task<UMSData> GetRoles(string username, Appname appname)
        {
            UMSBindings.UmsAppUrlMap.TryGetValue(appname, out string appUrl);
            UmsService.GetUserAppDetailsbyUserNameApplicationUrlResponse response = await new UmsService.UserProviderClient().GetUserAppDetailsbyUserNameApplicationUrlAsync(new UmsService.GetUserAppDetailsbyUserNameApplicationUrlRequest {
                userName = username,
                applicationUrl = appUrl
            });

            var result = response.GetUserAppDetailsbyUserNameApplicationUrlResult;

            //initialize returned role list
            var umsData = new UMSData();
            umsData.Appname = appname;

            //create a data set from returned xelement list
            DataSet dataSet = new DataSet();

            //read schema 
            dataSet.ReadXmlSchema(new StringReader(result.Nodes[0].ToString()));
            //read data tables
            for (int i = 1; i < result.Nodes.Count; i++)
            {
                dataSet.ReadXml(new StringReader(result.Nodes[i].ToString()));
            }


            if (dataSet.Tables.Count == 4 && dataSet.Tables[3] != null)
            {
                for (int i = 0; i < dataSet.Tables[3].Rows.Count; i++)
                {
                    var userRole = dataSet.Tables[3].Rows[i]["SUBGROUP_NAME"].ToString();
                    umsData.Roles.Add(userRole);
                }
            }

            return umsData;
        }
    }
}