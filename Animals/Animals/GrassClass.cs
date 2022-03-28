using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Grass
    {
        private Simulation simulationClass;

        private int grassReproductionRateSet = 1;

        public Grass(int grassReproductionRate, Simulation simulation)
        {
            this.simulationClass = simulation;
            this.grassReproductionRateSet = grassReproductionRate;
        }

        public void Reproduce()
        {
            for (int i = 0; i < grassReproductionRateSet; i++)
            {
                Grass grass = new Grass(grassReproductionRateSet, simulationClass);
                simulationClass.grassList2.Add(grass);
            }
        }
    }
}
