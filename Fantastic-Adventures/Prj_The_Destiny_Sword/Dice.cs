using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_The_Destiny_Sword
{
    class Dice
    {
        public int value;
        public int number;
        Random random = new Random(DateTime.Now.Millisecond);
        
        public Dice(){}

        public Dice(int number, int value)
        {
            this.number = number;
            this.value = value;
        }

        public int Roll(int number, int value)
        {
            int result = 0;
            for (int i = 0; i < number; i++)
                result += random.Next(0, value);
            return result;
        }
    }
}
