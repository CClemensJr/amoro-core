using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static Random _generator = new Random();

        public static int NumberBetween(int minimum, int maximum)
        {
            return _generator.Next(minimum, maximum + 1);
        }
    }
}
