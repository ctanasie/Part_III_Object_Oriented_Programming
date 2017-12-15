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
