namespace Practice1
{
    class PoliceCar : VehicleWithPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car";
        private string lastPursuedVehicle;
        private bool isPatrolling;
        private bool isPursuing;
        private bool hasRadar;
        private SpeedRadar speedRadar;
        private PoliceStation associatedPoliceStation;

        public PoliceCar(string plate,PoliceStation associatedPoliceStation, bool hasRadar) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            isPursuing = false;
            this.hasRadar = hasRadar;
            if (hasRadar)
            {
                speedRadar = new SpeedRadar();
            }
            this.associatedPoliceStation = associatedPoliceStation;
        }

        public void UseRadar(Vehicle vehicle)
        {
            if (isPatrolling && hasRadar)
            {
                speedRadar.TriggerRadar(vehicle);
                string meassurement = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
                if (meassurement.Contains("Catched above legal speed."))
                {
                    if (vehicle is VehicleWithPlate vehicleWithPlate)
                    {
                        associatedPoliceStation.ActivateAlarm(vehicleWithPlate.GetPlate());
                    }
                    else
                    {
                        associatedPoliceStation.ActivateAlarm("No plate");
                    }
                }
            }
            else if (hasRadar)
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
            else
            {
                Console.WriteLine(WriteMessage($"has no radar."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            if (hasRadar)
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("Has no radar"));
            }
        }

        public void StartPursuit(string plate)
        {
            if (isPatrolling)
            {
                isPursuing = true;
                lastPursuedVehicle = plate;
            }

            
        }
        public void StopPursuit()
        {
            if (isPursuing)
            {
                isPursuing = false;
            }
        }
    }
}