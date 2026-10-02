namespace DiscordKnockoff.DataAccess;

public class Server
{
    public long Id { get; set; }
    public required string ServerName  { get; set; }
    public DateTime  CreatedAt { get; set; }
    public bool Deleted { get; set; } = false;
    
    public ICollection<Channel>  Channels { get; set; } = [];
    public ICollection<User> Members { get; set; } =  [];
}