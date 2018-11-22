﻿using System;
using System.Collections.Generic;
using System.Text;
using GrandPrix.Entities.Cars;

namespace GrandPrix.Entities.Drivers
{
    public class EnduranceDriver : Driver
    {
        private const double curFuelConsumtion = 1.5;

        public EnduranceDriver(string name, Car car) 
            : base(name, car, curFuelConsumtion)
        {
        }
    }
}
