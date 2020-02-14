using Grpc.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileWebApiLibrary;
using MobileWebApiLibrary.Action_Filters;
using MobileWebApiLibrary.Controllers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Session_WebApi.Controllers.V2
{
    [ApiVersion("2")]
    //[Route("SessionApi/v{version:apiVersion}/")]
    [Route("SessionApi/v2/")]
    public class SessionController : BaseController
    {
    }
}