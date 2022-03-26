using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Simulation
    {

        public List<object> numberOfFoxes;
        public List<object> numberOfRabbits;

        public Simulation(int Foxes, int Rabbits, int steps)
        {
            List<object> numberOfFoxes = new List<object>();
            List<object> numberOfRabbits = new List<object>();

            for (int i = 0; i < Foxes; i++)
            {
                Fox fox = new Fox();
                numberOfFoxes.Add(fox);
                Console.WriteLine("Created Fox");
            }

            for (int i = 0; i < Rabbits; i++)
            {
                Rabbit rabbit = new Rabbit();
                numberOfRabbits.Add(rabbit);
                Console.WriteLine("Created Rabbit");
            }
        }

        private void Steps(int steps)
        {
            //   Animal.IncreaseAge();
        }


        // remove Rabbit from simulation
        public void KillRabbit()
        {
            // removes by ID
            numberOfRabbits.Remove(1);
        }

        // remove fox from simulation
        public void KillFox()
        {
            // removes by ID
            numberOfFoxes.Remove(1);
        }




    }
}
