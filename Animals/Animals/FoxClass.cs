using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Fox : Animal
    {
        public Fox(int age, bool alive, int hunger)
        {
            return;
        }

        // randomly select Rabbit to kill and remove that Rabbit from simulation, sets hunger to 0.
        public void Hunt()
        {
            var random = new Random();
            int index = random.Next(Simulation.rabbitList.Count);
            Simulation.KillRabbit(index);
            hunger = 0;
        }

        public override void Reproduce()
        {
            Fox fox = new Fox(0, true, 0);
            Simulation.foxList.Insert(0, fox);
        }

        public override void Kill()
        {
            if (alive == false)
            {
                Simulation.foxList.RemoveAt(0);
            }
        }



    }
}
