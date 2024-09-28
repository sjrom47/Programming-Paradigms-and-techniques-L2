using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class PoliceStation 
    {   
        List<VehicleWithPlate> registeredPoliceVehicles;
        public PoliceStation() {
            registeredPoliceVehicles = new List<VehicleWithPlate>();
        }

        public VehicleWithPlate RegisterPoliceVehicle(string plate, bool hasRadar)
        {
            PoliceCar newPoliceCar = new PoliceCar(plate, this, hasRadar);
            registeredPoliceVehicles.Add(newPoliceCar);
            return newPoliceCar;
        }

        public void RemovePoliceVehicle(string plate)
        {
            int i = 0;
            while (registeredPoliceVehicles[i].GetPlate() != plate)
            {
                i++;
            }
            registeredPoliceVehicles.RemoveAt(i);
        }

        public void ActivateAlarm(string plate)
        {
            Console.WriteLine($"Currently pursuing vehicle with plate: {plate}");
            foreach (var vehicle in registeredPoliceVehicles)
            {
                if (vehicle is PoliceCar policeCar)
                {
                    policeCar.StartPursuit(plate);
                }
            }
        }
        public void DeactivateAlarm()
        {
            Console.WriteLine("The vehicle has been captured");
            foreach(var vehicle in registeredPoliceVehicles)
            {
                if (vehicle is PoliceCar policeCar)
                {
                    policeCar.StopPursuit();
                }
            }
        }
    }
}
