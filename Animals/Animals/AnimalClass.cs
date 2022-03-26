using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {

        protected int age = 0;
        protected bool alive = true;
        protected int hunger = 0;

        // Start is called before the first frame update
        public virtual int GetAge()
        {
            return age;
        }

        // kill animal
        public void SetDead()
        {
            alive = false;
        }

        public virtual void Eat()
        {

        }

        //reproduce between 4 and 6 animals randomly
        public void Reproduce()
        {

        }

        // increase age of animal by one
        public void IncreaseAge()
        {
            age++;
        }

        // kills animal if hunger exceeds 100
        public void Starve()
        {
            if (hunger >= 100)
            {
                // kill animal
                SetDead();
            }
        }

    }
}
