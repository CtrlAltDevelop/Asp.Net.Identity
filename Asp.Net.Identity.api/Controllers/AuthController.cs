using Asp.Net.Identity.api.Services;
using Asp.Net.Identity.shared;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net.Identity.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> RegisterAsync([FromBody]RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _userService.RegisterUserAsync(model);
            if (result.IsSuccess)
                return Ok(result);
        }

        return BadRequest("Some properties are not valid");
    }
}
