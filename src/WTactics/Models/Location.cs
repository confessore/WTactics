namespace WTactics.Models
{
    public class Location
    {
        public Location() { }
        public Location(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X { get; set; }
        public float Y { get; set; }
    }
}
