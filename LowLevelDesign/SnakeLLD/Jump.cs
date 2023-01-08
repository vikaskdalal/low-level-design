namespace LowLevelDesign.SnakeLLD
{
    public class Jump
    {
        public Jump(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int Start { get; set; }
        public int End { get; set; }
    }
}
