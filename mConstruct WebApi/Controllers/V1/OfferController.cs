using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mConstruct_WebApi.Controllers
{
    [ApiVersion("1")]
    [Route("mConstruct/v1/[controller]/[action]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
    }
}