using Grpc.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileWebApiLibrary;
using MobileWebApiLibrary.Action_Filters;
using MobileWebApiLibrary.Controllers;
using System;
using System.Threading.Tasks;

namespace Session_WebApi.Controllers.V2
{
    [ApiVersion("2")]
    //[Route("SessionApi/v{version:apiVersion}/")]
    [Route("SessionApi/v2/")]
    public class SessionController : BaseController
    {
        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<UserSession>> Login([FromBody] LoginRequest loginRequest)
        {
            //if (string.IsNullOrEmpty(loginRequest.Username) || string.IsNullOrEmpty(loginRequest.Password))
            //    throw new HttpResponseException
            //    {
            //        Status = StatusCodes.Status401Unauthorized,
            //        Value = new ProblemDetails
            //        {
            //            Status = StatusCodes.Status401Unauthorized,
            //            Instance = HttpContext.Request.Path.Value,
            //            Title = "Empty username or password",
            //            Detail = string.Format("Username is {0}", loginRequest.Username)
            //        }
            //    };


            //validateApp(loginRequest.AppName, loginRequest.AppVersion);

            ////authenticate user
            //await AuthenticateUserInUMS(loginRequest.Username, loginRequest.Password);
            throw new Exception("Fuck");
            UserSession userSession = new UserSession();
            userSession.Token = "abcd";
            userSession.Roles.Add(Role.FieldEngineer);

            
            return userSession;

        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task AuthenticateUserInUMS(string username, string password)
        {
            //create UMS Service instance
            UMSService.UserProviderClient umsServiceProvider = new UMSService.UserProviderClient();

            try
            {
                UMSService.AuthenticateUserResponse authenticateUserResponse = await umsServiceProvider.AuthenticateUserAsync(new UMSService.AuthenticateUserRequest
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
            catch(Exception ex)
            {
                throw ex;
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
                        Detail = "Application version can not be 0"
                    }
                };

            //get latest app version
            int latestAppVersion = -1;
            AppVersions.appVersionMappings.TryGetValue(appName, out latestAppVersion);

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
                    Title = "This app version is no longer supported. Please update to the latest version from Airwatch.",
                    Detail = string.Format("AppVersion : {0} is different than latest appversion : {1}.", appVersion, latestAppVersion)
                }
            };

        }
    }
}