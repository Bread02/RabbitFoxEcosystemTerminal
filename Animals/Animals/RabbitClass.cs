using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Rabbit : Animal
    {
        private Simulation simulationClass;
        private int grassEatAmount = 5;

        // creates a rabbit.
        public Rabbit(int age, bool alive, int hunger, Simulation simulation)
        {
            simulationClass = simulation;
        }

        // a rabbit eats 1 grass per step, so destroys a random grass from the grassList2.
        public override void Eat()
        {
            for (int i = 0; i < grassEatAmount; i++)
            {
                if (simulationClass.grassList2.Count != 0)
                {
                    var random = new Random();
                    int index = random.Next(simulationClass.grassList2.Count);
                    simulationClass.DestroyGrass(index);
                    hunger = 0;
                }
                else
                {
                    Console.WriteLine("No grass to eat");
                    IncreaseHunger();
                }
            }
        }

        // reproduces between 4 and 6 rabbits if old enough. Adds rabbit onto rabbitList2.
        public void Reproduce()
        {
            Rabbit rabbit = new Rabbit(0, true, 0, simulationClass);
            simulationClass.rabbitList2.Insert(0, rabbit);
        }


        // Kills rabbit and removes from rabbitList2
        public override void Kill()
        {
                simulationClass.rabbitList2.RemoveAt(0);
        }


    }
}
