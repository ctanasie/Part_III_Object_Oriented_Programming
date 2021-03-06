﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        // The 'state' of the car.
        public string petName;
        public int currSpeed;

        // A custom default constructor.
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        // Here, currSpeed will receive the default value of an int (zero).
        public Car(string pn)
        {
            petName = pn;
        }

        // Let caller set the full state of the Car.
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        // The functionality of the car.
        public void PrintState()
        {
            Console.WriteLine($"{petName} is going {currSpeed} MPH.");
        }

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
