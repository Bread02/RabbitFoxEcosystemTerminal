using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Grass
    {
        private int grassReproductionRate;
        public Grass(int grassReproductionRate)
        {
            return;
        }

        public void Reproduce()
        {
            for (int i = 0; i < grassReproductionRate; i++)
            {
                Grass grass = new Grass(grassReproductionRate);
            }
        }
    }
}
