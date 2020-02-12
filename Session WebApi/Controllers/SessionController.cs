using Grpc.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileWebApiLibrary;
using MobileWebApiLibrary.Action_Filters;
using MobileWebApiLibrary.Controllers;

namespace Session_WebApi.Controllers
{
    [Route("SessionApi/")]
    public class SessionController : BaseController
    {
        [Route("[action]")]
        [HttpPost]
        public ActionResult<UserSession> Login([FromBody] LoginRequest loginRequest)
        {
            if (loginRequest.AppVersion < ApkVersions.mConstruct)
                throw new HttpResponseException
                {
                    Status = StatusCodes.Status400BadRequest,
                    Value = new ProblemDetails
                    {
                        Status = GISStatusCodes.Status911UnsupportedAppVersion,
                        Instance = HttpContext.Request.Path.Value,
                        Title = "This app version is no longer supported. Please update to the latest version from Airwatch.",
                        Detail = string.Format("AppVersion : {0} is less than latest appversion : {1}.", loginRequest.AppVersion, ApkVersions.mConstruct)
                    }
                };

            UserSession userSession = new UserSession();
            userSession.Token = "abcd";
            userSession.Roles.Add(Role.FieldEngineer);

            
            return userSession;

        }
    }
}