using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Simulation
    {

        public static List<Fox> foxList = default!;
        public static List<Rabbit> rabbitList = default!;

        public Simulation(int Foxes, int Rabbits, int steps)
        {
            List<Fox> foxList = new List<Fox>();
            List<Rabbit> rabbitList = new List<Rabbit>();

            for (int i = 0; i < Foxes; i++)
            {
                Fox fox = new Fox();
                foxList.Add(fox);
                Console.WriteLine("Created Fox");
            }

            for (int i = 0; i < Rabbits; i++)
            {
                Rabbit rabbit = new Rabbit();
                rabbitList.Add(rabbit);
                Console.WriteLine("Created Rabbit");
            }
        }

        private void Steps(int steps)
        {
            //   Animal.IncreaseAge();
        }


        // remove Rabbit from simulation
        public static void KillRabbit(int index)
        {
            // removes by ID
           // rabbitList.Remove();
        }

        // remove fox from simulation
        public void KillFox(int index)
        {
            // removes by ID
          //  foxList.Remove();
        }




    }
}
