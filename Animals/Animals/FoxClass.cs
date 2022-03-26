using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Fox : Animal
    {
        public Fox()
        {
            Fox fox = new Fox();
        }

        // randomly select Rabbit to kill and remove that Rabbit from simulation, sets hunger to 0.
        public void Hunt()
        {
            var random = new Random();
            int index = random.Next(Simulation.rabbitList.Count);
            Simulation.KillRabbit(index);
            hunger = 0;
        }

    }
}
