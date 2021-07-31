using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public static class Validator
    {
        public static void ThrowIfNameIsNullOrWhiteSpace(string str, string message)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(message); 
            }
        }

        public static void ThrowIfValueIsOutOfRange(int val, int minNum, int maxNum, string message)
        {
            if (val < minNum || val > maxNum)
            {
                throw new ArgumentException(message);
            }
        }


    }
}
