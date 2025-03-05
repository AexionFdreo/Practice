using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Guessing
{
    public class GuessingCore
    {
        private const int minNum = 1;
        private const int maxNum = 100;
        public int num { get; set; }
        public int attempts {  get; set; } = 0;

        public GuessingCore()
        {
            makeUpNumber();
        }

        public void makeUpNumber()
        {
            Random rand = new();
            num = rand.Next(maxNum-minNum+1) + minNum;
        }

        public int guess(int num)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(num, maxNum);
            ArgumentOutOfRangeException.ThrowIfLessThan<int>(num, minNum);
            
            attempts++;
            if (num > this.num)
            {
                return -1;
            }
            else if (num < this.num)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
