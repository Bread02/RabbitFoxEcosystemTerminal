using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Rabbit : Animal, IRabbit
    {
        private Simulation simulation { get; set; }

        private List<Rabbit> rabbitList {  get; set; }

        public Rabbit(int age, bool alive, int hunger, Simulation simulation)
        {
            simulation = simulation.GetSimulation();
            rabbitList = simulation.rabbitList2;
        }

        // a rabbit eats 1 grass per step
        public override void Eat()
        {
            var random = new Random();
            int index = random.Next(simulation.grassList2.Count);
            simulation.DestroyGrass(index);
            hunger = 0;
        }

        // reproduces between 4 and 6 rabbits if old enough
        public override void Reproduce()
        {
            if (age > 0)
            {
                Rabbit rabbit1 = new Rabbit(0, true, 0, simulation);
              //  simulation.rabbitList2.Insert(0, rabbit1);
                rabbitList.Insert(99, rabbit1);
            }
        }

        public override void Kill()
        {
            if (alive == false)
            {
                simulation.rabbitList2.RemoveAt(0);
            }
        }


    }
}
