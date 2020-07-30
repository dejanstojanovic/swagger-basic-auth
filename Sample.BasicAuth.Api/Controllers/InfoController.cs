using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sample.BasicAuth.Api.Models;

namespace Sample.BasicAuth.Api.Controllers
{
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<InfoModel> Get()
        {
            return Ok(new InfoModel());
        }
    }
}
