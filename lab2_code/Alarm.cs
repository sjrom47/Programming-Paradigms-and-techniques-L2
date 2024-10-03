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
            // We implement that if statement to make sure that if another type of police
            // vehicle that could not pursue cars was implemented (or it had a different behaviour)
            // then they could have a different behaviour
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
