﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Scooter:VehicleWithoutPlate
    {
        const string typeOfVehicle = "Scooter";
        public Scooter() : base(typeOfVehicle) { }
    }
}
