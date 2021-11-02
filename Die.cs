using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enjmin_Minivilles_Console
{
    public class Die
    {
        private Random random;
        private int face = 7;
        private List<List<int>> tableauDe = new List<List<int>>();
        public int diceValue { get; private set; }

        public Die()
        {           
            random = new Random();
            Tossing();
            TabInit();
        }

        private void TabInit()
        {
            tableauDe.Add(new List<int>{2,3,4,5,6});
            tableauDe.Add(new List<int>{});
            tableauDe.Add(new List<int>{4,5,6});
            tableauDe.Add(new List<int>{6});
            tableauDe.Add(new List<int>{1,3,5});
            tableauDe.Add(new List<int>{6});
            tableauDe.Add(new List<int>{4,5,6});
            tableauDe.Add(new List<int>{});
            tableauDe.Add(new List<int>{2,3,4,5,6});
        }
        
        public void Tossing()
        {
            diceValue = random.Next(1, face);
        }

        public string[] ToString()
        {
            string[] lignes = new string[5];
            if (diceValue > 6)
            {
                return (new string[]{diceValue.ToString()});
            }
            else
            {
                lignes[0] = " _________ ";
                for (int loop = 0; loop < 3; loop++)
                {
                    lignes[loop+1] += "|";
                    for (int loop1 = 0; loop1 < 3; loop1++)
                    {
                        if (tableauDe[loop*3 + loop1].Contains(diceValue))
                        {
                            lignes[loop+1] += " * ";
                        }
                        else
                        {
                            lignes[loop+1] += "   ";
                        }
                    }

                    lignes[loop+1] += "|";
                }

                lignes[4] += " --------- ";
                return lignes;
            }
        }


    }
}
