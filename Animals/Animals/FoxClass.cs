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

        }

        // randomly select Rabbit to kill and remove that Rabbit from simulation.
        public override void Eat()
        {
            var random = new Random();
            int index = random.Next(Simulation.rabbitList.Count);
            Simulation.KillRabbit(index);
        }

    }
}
