﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class CreateSimulation
    {
        // creates a simulation with the specified starting number of rabbits, foxes and steps
        public static void Main(string[] args)
        {
            Simulation simulation = new Simulation(2, 10, 2);
            Animal animal = new Animal();
        }
    }
}
