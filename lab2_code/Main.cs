namespace Practice1
{
    internal class Program
    {
        static void Main()
        {
            // TODO: city and Police station messages
            // Creation of the different vehicles, city and Police station
            City city = new City();
            Console.WriteLine(city.WriteMessage("Created"));

            PoliceStation station = new PoliceStation();
            Console.WriteLine(station.WriteMessage("Created"));

            city.AddPoliceStation(station);
            Console.WriteLine(city.WriteMessage("Now has a police station"));

            Taxi taxi1 = (Taxi)city.RegisterVehicle("0000AAA");
            Taxi taxi2 = (Taxi)city.RegisterVehicle("0000BBB");
            Console.WriteLine(taxi1.WriteMessage("Created")); 
            Console.WriteLine(taxi2.WriteMessage("Created"));

            PoliceCar police1 = (PoliceCar)station.RegisterPoliceVehicle("0000CNP", true);
            PoliceCar police2 = (PoliceCar)station.RegisterPoliceVehicle("0001CNP", false);
            Console.WriteLine(police1.WriteMessage("Created"));
            Console.WriteLine(police2.WriteMessage("Created"));


            police2.UseRadar(taxi1);

            // Setting the stage for a police car catching a car over the speed limit
            taxi2.StartRide();
            police1.StartPatrolling();
            police2.StartPatrolling();
            police1.UseRadar(taxi2);

            // Taxi is caught, license is removed
            station.DeactivateAlarm();
            city.RemoveVehicle(taxi2.GetPlate());




        }
    }
}
    

