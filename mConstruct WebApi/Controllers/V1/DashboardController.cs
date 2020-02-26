using Grpc.services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace mConstruct_WebApi.Controllers
{
    [ApiVersion("1")]
    [Route("mConstruct/v1/[controller]/[action]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        public async Task<ActionResult<DashboardData>> GetDashboardData([FromBody] DashboardDataRequest request)
        {
            throw new NotImplementedException();
        }
    }
}