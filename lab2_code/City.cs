using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class City 
    {
        List<Vehicle> vehicleLicenses;
        PoliceStation cityPoliceStation;
        public City() { }

        public void AddPoliceStation(PoliceStation policeStation)
        {
            this.cityPoliceStation = policeStation;
        }
        public void RegisterVehicle(string plate)
        {
            PoliceCar newTaxi = new PoliceCar(plate, this, hasRadar);
            registeredPoliceVehicles.Add(newTaxi);

        }

        public void RemoveVehicle(string plate)
        {
            int i = 0;
            while (vehicleLicenses[i].GetPlate() != plate)
            {
                i++;
            }
            vehicleLicenses.RemoveAt(i);
        }
    }
}
