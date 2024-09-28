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
        public PoliceStation() { }

        public void RegisterPoliceVehicle(string plate, bool hasRadar)
        {
            PoliceCar newPoliceCar = new PoliceCar(plate, this, hasRadar);
            registeredPoliceVehicles.Add(newPoliceCar);
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
