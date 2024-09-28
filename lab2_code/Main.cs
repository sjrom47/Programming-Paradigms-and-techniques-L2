namespace Practice1
{
    internal class Program
    {
        static void Main()
        {
            City city = new City();

            PoliceStation station = new PoliceStation();

            city.AddPoliceStation(station);

            Taxi taxi1 = (Taxi)city.RegisterVehicle("0000AAA");
            Taxi taxi2 = (Taxi)city.RegisterVehicle("0000BBB");

            PoliceCar police1 = (PoliceCar)station.RegisterPoliceVehicle("0000CNP", true);
            PoliceCar police2 = (PoliceCar)station.RegisterPoliceVehicle("0001CNP", false);

            police2.UseRadar(taxi1);
            taxi2.StartRide();
            police1.StartPatrolling();
            police2.StartPatrolling();
            police1.UseRadar(taxi2);
            station.DeactivateAlarm();
            city.RemoveVehicle(taxi2.GetPlate());




        }
    }
}
    

