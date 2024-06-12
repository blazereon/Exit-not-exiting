public class Room
{
    private Dictionary<Cardinal, Room> directions;

    public Room()
    {
        directions = new Dictionary<Cardinal, Room>
        {
            { Cardinal.North, null },
            { Cardinal.South, null },
            { Cardinal.East, null },
            { Cardinal.West, null }
        };
    }
}