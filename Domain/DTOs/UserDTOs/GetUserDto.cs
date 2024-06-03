namespace Domain.DTOs.UserDTOs;

public class GetUserDto
{
    public int Id { get; set; }
    public required string Username { get; set; } 
    public required string Email { get; set; } 
    public string Phone { get; set; } = null!; 
    public DateTimeOffset CreateAt { get; set; }
    public DateTimeOffset UpdateAt { get; set; }
}