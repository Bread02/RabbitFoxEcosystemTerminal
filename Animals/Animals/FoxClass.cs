using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Fox : Animal
    {
        public Simulation simulationClass;

        public Fox(int age, bool alive, int hunger, Simulation simulation)
        {
            this.simulationClass = simulation;
        }

        // randomly select Rabbit to kill and remove that Rabbit from simulation, sets hunger to 0.
        public void Hunt()
        {
            var random = new Random();
            int index = random.Next(simulationClass.rabbitList2.Count);
            simulationClass.KillRabbit(index);
            hunger = 0;
        }

        
        public void Reproduce()
        {
            Fox fox = new Fox(0, true, 0, simulationClass);
            simulationClass.foxList2.Insert(0, fox);
        }
        
        public override void Kill()
        {
            if (alive == false)
            {
                simulationClass.foxList2.RemoveAt(0);
            }
        }



    }
}
