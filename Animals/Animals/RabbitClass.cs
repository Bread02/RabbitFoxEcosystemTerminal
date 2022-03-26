using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Rabbit : Animal, IRabbit
    {
        public Rabbit()
        {
            GetAge();
        }

        public override int GetAge()
        {
            Console.Write(base.GetAge());
            return base.GetAge();
        }

        public override void Eat()
        {

        }

        // reproduces between 4 and 6 rabbits
        public override void Reproduce()
        {

        }


    }
}
