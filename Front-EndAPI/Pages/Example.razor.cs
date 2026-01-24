using ClassLibrary.Entities;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

public class ExampleBase : ComponentBase
{
    [Inject]
    protected HttpClient Http { get; set; } = default!;

    protected CharacterEntity? example;

    protected override async Task OnInitializedAsync()
    {
        await LoadExample();
    }

    protected async Task LoadExample()
    {
        example = await Http.GetFromJsonAsync<CharacterEntity>("Example/items") ?? new();
    }
}
