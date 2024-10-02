using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Alarm
    {
        
        public Alarm() { }

        public void ActivateAlarm(string plate, List<VehicleWithPlate> registeredPoliceVehicles)
        {
            
            foreach (var vehicle in registeredPoliceVehicles)
            {
                if (vehicle is PoliceCar policeCar)
                {
                    policeCar.StartPursuit(plate);
                }
            }
        }
        public void DeactivateAlarm(List<VehicleWithPlate> registeredPoliceVehicles)
        {
            foreach (var vehicle in registeredPoliceVehicles)
            {
                if (vehicle is PoliceCar policeCar)
                {
                    policeCar.StopPursuit();
                }
            }
        }
    }   
}
