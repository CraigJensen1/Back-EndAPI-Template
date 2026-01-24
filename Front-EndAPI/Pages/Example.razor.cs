using ClassLibrary.Entities;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

public class ExampleBase : ComponentBase
{
    [Inject]
    protected HttpClient Http { get; set; } = default!;

    protected List<CharacterEntity> characters;

    protected override async Task OnInitializedAsync()
    {
        await LoadExample();
    }

    protected async Task LoadExample()
    {
        characters = await Http.GetFromJsonAsync<List<CharacterEntity>>("character/characters") ?? new();
    }
}
