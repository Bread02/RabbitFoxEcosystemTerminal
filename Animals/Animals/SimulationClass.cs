using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Simulation
    {
        // objects
        private Animal animal;
        private Fox fox;
        private Rabbit rabbit;
        private Grass grass;
        private int numberOfSteps;

        public Simulation simulation { get; set; }


        public List<Fox> foxList2 = new List<Fox>();
        public List<Rabbit> rabbitList2 = new List<Rabbit>();
        public List<Grass> grassList2 = new List<Grass>();

        public static List<Rabbit> rabbitsToAdd = new List<Rabbit>();

        // creates the fox and rabbit list, and sets number of steps to run the simulation.
        public Simulation(int Foxes, int Rabbits, int Grass, int steps)
        {

            simulation = this;
            // create lists then store them as a class variable
            List<Fox> foxList = new List<Fox>();
            foxList = foxList2;

            List<Rabbit> rabbitList = new List<Rabbit>();
            rabbitList = rabbitList2;

            List<Grass> grassList = new List<Grass>();
            grassList = grassList2;

            numberOfSteps = steps;

            for (int i = 0; i < Foxes; i++)
            {
                Fox fox = new Fox(0, true, 0);
                foxList2.Insert(0, fox);
                Console.WriteLine("Created Fox");
            }

            for (int i = 0; i < Rabbits; i++)
            {
                Rabbit rabbit = new Rabbit(0, true, 0, simulation);
                rabbitList2.Insert(0, rabbit);
                Console.WriteLine("Created Rabbit");
            }

            for (int i = 0; i < Grass; i++)
            {
                Grass grass = new Grass(10);
                grassList2.Insert(0, grass);
                Console.WriteLine("Created Grass");
            }

            Steps();
        }

        // one step ages an animal, increases an animal's hunger and triggers reproduction.
        // one step also lets foxes kill rabbits.
        private void Steps()
        {

            for (int i = 0; i < numberOfSteps; i++)
            {
                // complete rabbit steps
                rabbitList2.ForEach(rabbit => rabbit.IncreaseAge());
                rabbitList2.ForEach(rabbit => rabbit.Kill());
             //   rabbitList2.ForEach(rabbit => rabbit.Reproduce());

                foreach(var rabbit in rabbitList2)
                {
                    rabbit.Reproduce();
                }
                /*
                // try to get this to copy the reproduce code, currently doubling rabbit population
                var fixedSize = rabbitList2.ToArray();
                foreach(var rabbit in fixedSize)
                {
                    rabbitList2.Add(rabbit);
                }
                */

                rabbitList2.ForEach(rabbit => rabbit.IncreaseHunger());
                rabbitList2.ForEach(rabbit => rabbit.Eat());


                // complete fox steps
                foxList2.ForEach(fox => fox.IncreaseAge());
                foxList2.ForEach(fox => fox.Kill());
                //  foxList2.ForEach(fox => fox.Reproduce());
                foxList2.ForEach(fox => fox.IncreaseHunger());
                foxList2.ForEach(fox => fox.Hunt());

                // complete grass steps
                //   grassList2.ForEach(grass => grass.Reproduce());
                Console.WriteLine("Step " + i + " complete.");
                Console.WriteLine("There are " + foxList2.Count + " foxes, " + rabbitList2.Count + " rabbits and " + grassList2.Count + " grass.");

                rabbitList2.AddRange(rabbitsToAdd);
            }
        }


        // remove Rabbit from simulation
        public void KillRabbit(int index)
        {
            simulation.rabbitList2.RemoveAt(index);
        }

        // remove fox from simulation
        public void KillFox(int index)
        {
            foxList2.RemoveAt(index);
        }

        public void DestroyGrass(int index)
        {
            grassList2.RemoveAt(index);
        }

        public Simulation GetSimulation()
        {
            return simulation;
        }





    }
}
