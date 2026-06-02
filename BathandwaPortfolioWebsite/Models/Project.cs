namespace BathandwaPortfolioWebsite.Models;

public class Project
{
    public string Slug { get; set; }
    
    public string Title { get; set; }
    
    public string Group { get; set; }
    
    public string[] TechStack { get; set; }
    
    public string Tagline { get; set; }
    
    public string ProjectStatus { get; set; }
    
    public string Description { get; set; }
    
    public string ProjectlinkUrl { get; set; }
    
    public string LiveUrl { get; set; }
    
    public string ImageUrl { get; set; }
    
    public bool Featured { get; set; }
    
    public string ProjectRole { get; set; }
    
    public string RoleDescription { get; set; }
    
    
}