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

namespace Session_WebApi
{
    [ApiVersion("1")]
    //[Route("SessionApi/v{version:apiVersion}/")]
    [Route("[controller]")]
    public class TestController : BaseController
    {
        private readonly IConfiguration configuration;

        public TestController(IConfiguration Configuration)
        {
            configuration = Configuration;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(GISStatusCodes.Status911UnsupportedAppVersion)]
        [Route("[action]")]
        [HttpPost]
        public async Task<ActionResult<UserSession>> Login([FromBody] LoginRequest loginRequest)
        {
            UserSession userSession = new UserSession();
            userSession.Username = loginRequest.Username;
            userSession.UmsDetails.Add((int)loginRequest.AppName, new UMSData { Appname = loginRequest.AppName });
            userSession.Token = "";

            Console.WriteLine("INSIDE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n" + loginRequest.Username);
            return userSession;

        }
    }
}