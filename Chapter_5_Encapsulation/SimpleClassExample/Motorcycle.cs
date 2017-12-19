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

        // New members to represent the name of the driver.
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

        // Put back the default constructor, which will set all data members to default values.
        public Motorcycle() { }

        // Our custom constructor.
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
    }
}
