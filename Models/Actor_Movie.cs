namespace MyCineTime.Models;

public class Actor_Movie // burayi joining model olarak tasarladim
{
    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    public int ActorId { get; set; }
    public Actor Actor { get; set; }
}