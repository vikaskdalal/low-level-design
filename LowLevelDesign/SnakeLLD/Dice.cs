using System;

namespace LowLevelDesign.SnakeLLD
{
    public class Dice
    {
        private const int MIN = 1;
        private const int MAX = 6;

        public Dice(int diceCount)
        {
            DiceCount = diceCount;
        }

        public int DiceCount { get; set; }

        public int RollDice()
        {
            int totalSum = 0;
            int diceUsed = 0;
            
            Random r = new Random();
            
            while (diceUsed < DiceCount)
            {
                totalSum += r.Next(MIN, MAX);
                diceUsed++;
            }

            return totalSum;
        }
    }
}
