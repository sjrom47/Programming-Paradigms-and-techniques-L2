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
        public City() 
        {
            vehicleLicenses = new List<Vehicle>();
        }

        public void AddPoliceStation(PoliceStation policeStation)
        {
            cityPoliceStation = policeStation;
        }
        public Vehicle RegisterVehicle(string plate)
        {
            // For now you can only register Taxis. The functionality for
            // other types of vehicles would require specifying the vehicle type
            Taxi newTaxi = new Taxi(plate);
            vehicleLicenses.Add(newTaxi);
            return newTaxi;

        }

        public void RemoveVehicle(string plate)
        {
            // For now you can't remove vehicles without plate
            foreach (Vehicle vehicle in vehicleLicenses)
            {
                if (vehicle is VehicleWithPlate vehicleWithPlate)
                {
                    if (vehicleWithPlate.GetPlate() == plate)
                    {
                        vehicleLicenses.Remove(vehicle);
                        break;
                    }
                }
            }
        }
    }
}
