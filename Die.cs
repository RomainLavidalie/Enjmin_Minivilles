using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enjmin_Minivilles_Console
{
    class Die
    {
        private Random random;
        private int face;

        public Die()
        {           
            face = 7;
            random = new Random();
        }

        public int Tossing()
        {
            int diceValue;
            
            diceValue = random.Next(0, face);

            return diceValue;
        }

        public override string ToString()
        {
            string toString = String.Format("+---+\n");
            toString += String.Format("| {0} |\n", Tossing());
            toString += String.Format("+---+\n");

            return toString;
        }


    }
}
