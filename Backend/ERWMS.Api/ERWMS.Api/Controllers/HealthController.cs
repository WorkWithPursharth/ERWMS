using Microsoft.AspNetCore.Mvc;

namespace ERWMS.Api.Controllers
{
	[ApiController]
	[Route("api/health")]
	public class HealthController : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{

			throw new Exception("Test exception");
		}
	}
}
