namespace DiscordKnockoff.DataAccess;

public class Channel
{
    public long Id { get; set; }
    public required string Name { get; set; }
    public long ServerId { get; set; }
    public DateTime  CreatedAt { get; set; }
    public bool Deleted { get; set; } = false;

    public ICollection<Message> Messages { get; set; } = [];
}