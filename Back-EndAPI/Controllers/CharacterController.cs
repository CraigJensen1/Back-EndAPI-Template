using ClassLibrary.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CharacterController : ControllerBase
{
    private readonly CharacterService _characterService;

    public CharacterController(CharacterService characterService)
    {
        _characterService = characterService;
    }

    // Controller returns DTOs
    [HttpGet("characters")]
    public async Task<ActionResult<List<CharacterDTO>>> Get()
    {
        var characters = await _characterService.GetCharactersAsync();
        return Ok(characters);
    }
}
