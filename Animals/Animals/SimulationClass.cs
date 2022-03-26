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
        public static List<Grass> grassList = default!;

        // creates the fox and rabbit list, and sets number of steps to run the simulation.
        public Simulation(int Foxes, int Rabbits, int steps)
        {
            List<Fox> foxList = new List<Fox>();
            List<Rabbit> rabbitList = new List<Rabbit>();
            List<Grass> grassList = new List<Grass>();

            for (int i = 0; i < Foxes; i++)
            {
                Fox fox = new Fox(0, true, 0);
                foxList.Insert(0, fox);
                Console.WriteLine("Created Fox");
            }

            for (int i = 0; i < Rabbits; i++)
            {
                Rabbit rabbit = new Rabbit(0, true, 0);
                rabbitList.Insert(0, rabbit);
                Console.WriteLine("Created Rabbit");
            }

            for (int i = 0; i < Rabbits; i++)
            {
                Grass grass = new Grass(10);
                grassList.Insert(0, grass);
                Console.WriteLine("Created Grass");
            }

            Steps(steps);
        }

        // one step ages an animal, increases an animal's hunger and triggers reproduction.
        // one step also lets foxes kill rabbits.
        private void Steps(int steps)
        {
            for (int i = 0; i <= steps; i++)
            {
                animal.IncreaseAge();
                animal.IncreaseHunger();
                animal.Reproduce();
                animal.Kill();

                Console.WriteLine("There are now " + foxList.Count + " foxes, " + rabbitList.Count + " rabbits and " + grassList.Count + " grass.");

            }
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
