namespace DiscordKnockoff.DataAccess;

public class User
{
    public long  Id { get; set; }
    public required string  Username { get; set; }
    public required string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Deleted { get; set; } = false;
    
    public ICollection<Server>  Servers { get; set; } = [];
}