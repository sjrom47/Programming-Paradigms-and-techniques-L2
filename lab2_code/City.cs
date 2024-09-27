using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class City : IManageVehicles
    {
        List<Vehicle> taxiLicenses;
        PoliceStation policeStation;
        public City() { }

        public void AddPoliceStation(PoliceStation policeStation)
        {
            this.policeStation = policeStation;
        }
        public void RegisterVehicle(string plate, string typeOfVehicle)
        {

        }

        public void RemoveVehicle(string plate)
        {

        }
    }
}
