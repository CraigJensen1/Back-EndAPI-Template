using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly CharacterService _chacterService;

    public CharacterController(CharacterService chacterService)
    {
        _chacterService = chacterService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var characters = await _chacterService.GetCharactersAsync();
        return Ok(characters);
    }
}
