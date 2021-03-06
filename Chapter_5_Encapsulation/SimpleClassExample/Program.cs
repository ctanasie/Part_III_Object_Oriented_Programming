﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            // Make a motorcycle with a rider named Tiny?
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Tiny");
            c.PopAWheely();

            Console.WriteLine($"Rider name is {c.driverName}");
            Console.WriteLine();

            MakeSomeBikes();
            Console.WriteLine();

            // Make a car called Chuck going 10 MPH.
            Car chuck = new Car();
            chuck.PrintState();

            // Make a car called Mary going 0 MPH.
            Car mary = new Car("Mary");
            mary.PrintState();

            // Make a car called Daisy going 75 MPH.
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            // Allocate and configure a Car object.
            Car myCar = new Car();
            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            // Speed up the car a few times and print out the new state.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Console.ReadLine();
        }

        static void MakeSomeBikes()
        {
            // driverName = "", driverIntensity = 0.
            Motorcycle m1 = new Motorcycle();
            Console.WriteLine($"Name = {m1.driverName}, Intensity = {m1.driverIntensity}");

            // driverName = "Tiny", driverIntensity = 0.
            Motorcycle m2 = new Motorcycle(name:"Tiny");
            Console.WriteLine($"Name = {m2.driverName}, Intensity = {m2.driverIntensity}");

            // driverName = "", driverIntensity = 7
            Motorcycle m3 = new Motorcycle(intensity: 7);
            Console.WriteLine($"Name = {m3.driverName}, Intensity = {m3.driverIntensity}");
        }
    }
}
