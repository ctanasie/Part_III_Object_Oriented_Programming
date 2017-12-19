using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        public void SetDriverName(string name)
        {
            // These two statements are functionally the same.
            driverName = name;
            this.driverName = name;
        }

        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeeeeeee Haaaaaaeeeeeeewww!");
            }
        }

        // Constructor chaining.
        public Motorcycle() { }

        public Motorcycle(int intensity) 
            : this (intensity, "") { }

        public Motorcycle(string name)
            : this (0, name) { }

        // This is the 'master' constructor that does all the real work.
        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }

            driverIntensity = intensity;
            driverName = name;
        }
    }
}
