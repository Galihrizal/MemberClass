using System;

namespace class_dan_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari class taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            if (taxi.OnDuty == true)
            {
                taxi.PickUpPassenger();
            }
            else
            {
                taxi.DropOffPassenger();
            }
            Console.ReadKey();
        }
    }
}
