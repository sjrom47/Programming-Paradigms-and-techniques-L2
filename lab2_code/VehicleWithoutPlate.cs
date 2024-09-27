using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class VehicleWithoutPlate:Vehicle
    {
        public VehicleWithoutPlate(string typeOfVehicle):base(typeOfVehicle)
        {

        }
        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} without plate";
        }
    }
}
