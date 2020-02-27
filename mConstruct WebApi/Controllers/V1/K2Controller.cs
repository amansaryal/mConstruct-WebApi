using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mConstruct_WebApi.Controllers
{
    [ApiVersion("1")]
    [Route("/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    public class K2Controller : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<AssignedJioPointsResponse>> GetAssignedJioPoints([FromBody] AssignedJioPointsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}