using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class PoliceStation : IMessageWritter
    {   
        // TODO: see if getter for the registered police vehicles is necessary
        List<VehicleWithPlate> registeredPoliceVehicles;
        Alarm alarm;
        public PoliceStation() {
            registeredPoliceVehicles = new List<VehicleWithPlate>();
            alarm = new Alarm();
        }

        public VehicleWithPlate RegisterPoliceVehicle(string plate, bool hasRadar)
        {
            // Right now it can only add police cars, but if some kind of flag
            // was given then it could be used to create other types of police vehicles
            PoliceCar newPoliceCar = new PoliceCar(plate, this, hasRadar);
            registeredPoliceVehicles.Add(newPoliceCar);
            return newPoliceCar;
        }

        public void RemovePoliceVehicle(string plate)
        {
            int i = 0;
            while (registeredPoliceVehicles[i].GetPlate() != plate && i < registeredPoliceVehicles.Count)
            {
                i++;
            }
            if (i < registeredPoliceVehicles.Count) {
                registeredPoliceVehicles.RemoveAt(i);
                Console.WriteLine(WriteMessage($"Removed vehicle with plate {plate}"));
            }
            else {
                Console.WriteLine(WriteMessage($"Vehicle with plate {plate} not found"));
            }
                
        }

        public void ActivateAlarm(string plate)
        {
            Console.WriteLine(WriteMessage($"Currently pursuing vehicle with plate: {plate}"));
            alarm.ActivateAlarm(plate,registeredPoliceVehicles);
        }

        

        public void DeactivateAlarm()
        {
            Console.WriteLine(WriteMessage("The vehicle has been captured"));
            alarm.DeactivateAlarm(registeredPoliceVehicles);
        }
        public string WriteMessage(string message)
        {
            // Since now only one police station is created the part before the colon
            // is hardcoded, but a ToString method could be created if at some point
            // more are created (would require some sort of ID)
            return $"Police Station: {message}";
        }

        public List<VehicleWithPlate> GetRegisteredPoliceVehicles() 
        { 
            return registeredPoliceVehicles; 
        }

    }
}
