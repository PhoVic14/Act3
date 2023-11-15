using System;
using System.Collections.Generic;
using System.Text;

namespace ACT3_Events
{
    internal class Calculs
    {
        public void ResoudreTrinome(float a, float b, float c, out string type)
        {
            type = null;
            double delta;
            double x1;
            double x2;

            delta = Math.Pow(b, 2) - 4 * a * c;
            if(delta >= 0)
            {
                if(delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta) / (-2 * a));
                    x2 = (-b - Math.Sqrt(delta) / (-2 * a));
                    type = "Il y a deux racines réelles :" + x1 + " et " + x2; 
                }
                else
                {
                    x1 = (-b) / (2 * a);
                    type = "Il y a une seule racine : "  + x1;
                }
            }
            else
            {
                type = "Il n'y a pas de racine";
            }
        }
    }
    
}
