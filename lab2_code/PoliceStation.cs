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
    }
}
