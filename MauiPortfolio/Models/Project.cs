namespace MauiPortfolio.Models;

public class Project
{
    public string Slug { get; set; } = "";
    public string Title { get; set; } = "";
    public string Summary { get; set; } = "";
    public string[] Tags { get; set; } = Array.Empty<string>();
    public string? Image { get; set; }   
    public string? RepoUrl { get; set; }  
    public string? DemoUrl { get; set; }  
}
