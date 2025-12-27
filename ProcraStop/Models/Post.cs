namespace ProcraStop.Models;
public class Post
{
    public required string ProfileImage { get; set; }
    public required string Title { get; set; }
    public required string Time { get; set; }
    public required string Description { get; set; }
    public required string PostImage { get; set; }
    public int Likes { get; set; }
    public int Comments { get; set; }
    public int Shares { get; set; }
}
