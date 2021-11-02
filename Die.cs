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
        private List<List<int>> tableauDe = new List<List<int>>();

        public Die()
        {           
            face = 7;
            random = new Random();
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
        
        public int Tossing()
        {
            int diceValue;
            
            diceValue = random.Next(0, face);

            return diceValue;
        }

        public string[] ToString()
        {
            int Face = Tossing();
            string[] lignes = new string[5];
            if (Face > 6)
            {
                return (new string[]{Face.ToString()});
            }
            else
            {
                lignes[0] = " _________ ";
                for (int loop = 0; loop < 3; loop++)
                {
                    lignes[loop+1] += "|";
                    for (int loop1 = 0; loop1 < 3; loop1++)
                    {
                        if (tableauDe[loop*3 + loop1].Contains(Face))
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
