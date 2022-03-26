using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Rabbit : Animal, IRabbit
    {
        public Rabbit(int age, bool alive, int hunger)
        {
            return;
        }

        // a rabbit eats 1 grass per step
        public override void Eat()
        {
            var random = new Random();
            int index = random.Next(Simulation.grassList2.Count);
            Simulation.DestroyGrass(index);
            hunger = 0;
        }

        // reproduces between 4 and 6 rabbits if old enough
        public override void Reproduce()
        {
            if (age > 0)
            {
                Rabbit rabbit = new Rabbit(0, true, 0);
                Simulation.rabbitList2.Insert(0, rabbit);
            }
        }

        public override void Kill()
        {
            if (alive == false)
            {
                Simulation.rabbitList2.RemoveAt(0);
            }
        }


    }
}
