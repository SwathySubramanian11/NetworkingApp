using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")] // localhost:5001/api/users
[ApiController]
public class BaseApiController : ControllerBase
{
}
