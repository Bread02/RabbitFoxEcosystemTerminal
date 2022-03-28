using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Simulation
    {
        private int numberOfSteps;

        public List<Fox> foxList2 = new List<Fox>();
        public List<Rabbit> rabbitList2 = new List<Rabbit>();
        public List<Grass> grassList2 = new List<Grass>();

        public static List<Rabbit> rabbitsToAdd = new List<Rabbit>();

        // creates the fox and rabbit list, and sets number of steps to run the simulation.
        public Simulation(int Foxes, int Rabbits, int Grass, int GrassReproductionRate, int numberOfSteps)
        {
            this.numberOfSteps = numberOfSteps;
            // create lists then store them as a class variable
            List<Fox> foxList = new List<Fox>();
            foxList = foxList2;

            List<Rabbit> rabbitList = new List<Rabbit>();
            rabbitList = rabbitList2;

            List<Grass> grassList = new List<Grass>();
            grassList = grassList2;

            for (int i = 0; i < Foxes; i++)
            {
                Fox fox = new Fox(0, true, 0, this);
                foxList2.Insert(0, fox);
                Console.WriteLine("Created Fox");
            }

            for (int i = 0; i < Rabbits; i++)
            {
                Rabbit rabbit = new Rabbit(0, true, 0, this);
                rabbitList2.Insert(0, rabbit);
                Console.WriteLine("Created Rabbit");
            }

            for (int i = 0; i < Grass; i++)
            {
                Grass grass = new Grass(GrassReproductionRate, this);
                grassList2.Insert(0, grass);
                Console.WriteLine("Created Grass");
            }
            Steps();
        }

        // one step ages an animal, increases an animal's hunger and triggers reproduction.
        // one step also lets foxes kill rabbits.
        public void Steps()
        {
            Console.WriteLine("Starting simulation");
            Console.WriteLine("running a simulation with " + numberOfSteps + " steps");
            for (int i = 1; i <= numberOfSteps; i++)
            {
                Console.WriteLine("Doing step " + i);

                // complete rabbit steps
                int rabbitsBeforeReproduction;
                rabbitsBeforeReproduction = rabbitList2.Count();

                for (int l = 0; l < rabbitsBeforeReproduction; l++)
                {
                    rabbitList2[l].Reproduce();
                    rabbitList2[l].Eat();
                    rabbitList2[l].Starve();
                }

                // complete fox steps
                int foxesBeforeReproduction;
                foxesBeforeReproduction = foxList2.Count();
                for (int v = 0; v < foxesBeforeReproduction; v++)
                {
                    foxList2[v].Reproduce();
                    foxList2[v].Hunt();
                    foxList2[v].Starve();

                }

                // complete grass steps
                int grassBeforeReproduction;
                grassBeforeReproduction = grassList2.Count();
                for(int m = 0; m < grassBeforeReproduction; m++)
                {
                    grassList2[m].Reproduce();
                }

                Console.WriteLine("Step " + i + " complete.");
                Console.WriteLine("There are " + foxList2.Count + " foxes, " + rabbitList2.Count + " rabbits and " + grassList2.Count + " grass.");
            }
        }

        // remove Rabbit from simulation
        public void KillRabbit(int index)
        {
            this.rabbitList2.RemoveAt(index);
        }

        // remove fox from simulation
        public void KillFox(int index)
        {
            foxList2.RemoveAt(index);
        }

        public void DestroyGrass(int index)
        {
            try
            {
                this.grassList2.RemoveAt(index);
            }
            catch (Exception)
            {
                return;
            }
        }

            public Simulation GetSimulation()
        {
            return(this);
        }



    }
}
