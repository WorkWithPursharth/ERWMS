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
			return Ok(new
			{
				status = "Healthy",
				service = "ERWMS.Api",
				timestamp = DateTime.UtcNow
			});
		}
	}
}
