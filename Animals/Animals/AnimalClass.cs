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


        public Animal()
        {
            return;
        }

        public virtual int GetAge()
        {
            return age;
        }

        // kill animal

        public virtual void Eat()
        {

        }

        public virtual void Kill()
        {

        }

        //reproduce between 4 and 6 animals
        public virtual void Reproduce()
        {
            
        }

        #region increase variables

        // increase age of animal by one
        public void IncreaseAge()
        {
            age++;
        }

        public void IncreaseHunger()
        {
            hunger += 50;
        }

#endregion



        // kills animal if hunger exceeds 100
        public void Starve()
        {
            if (hunger >= 100)
            {
                // kill animal
                alive = false;
                Kill();
            }
        }

    }
}
