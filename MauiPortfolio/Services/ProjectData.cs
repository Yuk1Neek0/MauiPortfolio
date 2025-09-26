namespace MauiPortfolio.Services;

public static class ProjectData
{
    public record Project(
        string Slug,           
        string Title,
        string Summary,
        string Description,
        string? RepoUrl = null 
    );

    public static readonly List<Project> All = new()
    {
        new("maui-weather", "Maui Weather",
            "A sample MAUI + Blazor app.",
            "A simple weather demo built with .NET MAUI + Blazor.",
            "https://github.com/xxx/weather"),

        new("todo-pro", "Todo Pro",
            "Cross-platform todo with sync.",
            "A todo app that syncs across devices using SQLite + cloud.",
            "https://github.com/xxx/todo"),

        new("photo-grid", "Photo Grid",
            "Image gallery and effects.",
            "An image gallery showcasing effects and camera integration.",
            "https://github.com/xxx/photo"),
    };

    public static Project? Get(string slug) => All.FirstOrDefault(p => p.Slug == slug);
}
