using System.Text.Json;
using MauiPortfolio.Models;

namespace MauiPortfolio.Services;

public class ProjectService
{
    public async Task<List<Project>> GetAllAsync()
    {
       
        using var stream = await FileSystem.OpenAppPackageFileAsync("data/projects.json");
        var projects = await JsonSerializer.DeserializeAsync<List<Project>>(stream,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        return projects ?? new();
    }

    public async Task<Project?> GetBySlugAsync(string slug)
        => (await GetAllAsync()).FirstOrDefault(p => p.Slug == slug);
}
