using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class CreateSimulation
    {

        // creates a simulation with the specified starting number of:
        // rabbits, foxes, grass, grass reproduction rate and steps
        public static void Main(string[] args)
        {
            Simulation simulation = new Simulation(2, 20, 1000, 1, 20);

        //    Animal animal = new Animal();
        }
    }
}
