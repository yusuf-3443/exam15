namespace Domain.Filters;

public class UserFilter:PaginationFilter
{
    public string? Username { get; set; }
    public string? Email { get; set; } 
    public string? Phone { get; set; } 
    public string? Status { get; set; }
}