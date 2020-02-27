using Microsoft.AspNetCore.Mvc;

namespace mConstruct_WebApi.Controllers
{
    [ApiVersion("1")]
    [Route("/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
    }
}