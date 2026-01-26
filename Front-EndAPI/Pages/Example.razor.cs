using ClassLibrary.DTOs;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

public class ExampleBase : ComponentBase
{
    [Inject]
    protected HttpClient Http { get; set; } = default!;

    // UI uses DTOs — never entities
    protected List<CharacterDTO> Characters = new();

    protected override async Task OnInitializedAsync()
    {
        await LoadCharacters();
    }

    protected async Task LoadCharacters()
    {
        Characters =
            await Http.GetFromJsonAsync<List<CharacterDTO>>(
                "character/characters"
            ) ?? new();
    }
}
