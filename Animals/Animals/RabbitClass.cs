using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Rabbit : Animal
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
    }
}
