namespace BathandwaPortfolioWebsite.Models;

public class Certificate
{
    public string Title { get; set; } = string.Empty;
    public string Issuer { get; set; } = string.Empty;
    public string? Group { get; set; }
    public string? IssuedDate { get; set; }
    public string Status { get; set; } = "Completed"; 
    public string? PdfUrl { get; set; }
    public string? CredentialUrl { get; set; }
}