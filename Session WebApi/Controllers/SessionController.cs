﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Session_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        [Route("api/[controller]/[action]")]
        [HttpPost]
        public ActionResult<UserSession> Login([FromBody] LoginRequest loginRequest)
        {
            
            Console.WriteLine("HEY HEY HEY" + loginRequest.Username);

            UserSession userSession = new UserSession();
            userSession.AppVersion = 23;
            userSession.Token = "abcd";
            userSession.Roles.Add(Role.FieldEngineer);

            return userSession;

        }
    }
}