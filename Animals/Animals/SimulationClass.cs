using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Simulation
    {
        public Animal animal;
        public static List<Fox> foxList = default!;
        public static List<Rabbit> rabbitList = default!;

        // creates the fox and rabbit list, and sets number of steps to run the simulation.
        public Simulation(int Foxes, int Rabbits, int steps)
        {
            List<Fox> foxList = new List<Fox>();
            List<Rabbit> rabbitList = new List<Rabbit>();

            for (int i = 0; i < Foxes; i++)
            {
                Fox fox = new Fox();
                foxList.Insert(0, fox);
                Console.WriteLine("Created Fox");
            }

            for (int i = 0; i < Rabbits; i++)
            {
                Rabbit rabbit = new Rabbit();
                rabbitList.Insert(0, rabbit);
                Console.WriteLine("Created Rabbit");
            }

            Steps(steps);
        }

        // one step ages an animal, increases an animal's hunger and triggers reproduction.
        // one step also lets foxes kill rabbits.
        private void Steps(int steps)
        {
              animal.IncreaseAge();
              animal.IncreaseHunger();
        }


        // remove Rabbit from simulation
        public static void KillRabbit(int index)
        {
            rabbitList.RemoveAt(index);
        }

        // remove fox from simulation
        public void KillFox(int index)
        {
            foxList.RemoveAt(index);
        }




    }
}
