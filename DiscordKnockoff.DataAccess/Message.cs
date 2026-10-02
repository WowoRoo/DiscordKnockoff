namespace DiscordKnockoff.DataAccess;

public class Message
{
    public long Id { get; set; }
    public long ChannelId { get; set; }
    public long UserId { get; set; }
    public required string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Deleted { get; set; } = false;
}