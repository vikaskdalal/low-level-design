namespace LowLevelDesign.SnakeLLD
{
    public class Player
    {
        public Player(int currentPosition, string name)
        {
            CurrentPosition = currentPosition;
            Name = name;
        }

        public int CurrentPosition { get; set; }

        public string Name { get; set; }
    }
}
