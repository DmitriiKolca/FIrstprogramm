using System;

namespace Program.Utils
{
    class Generator
    {
        public static int GenerateRandomNumber(int lowNumber, int highNumber)
        {
            Random rnd = new Random();
            return rnd.Next(lowNumber, highNumber + 1);
        }
    }
}