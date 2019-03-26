using System;

namespace class_dan_properties
{
    class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name         : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty ? "Yes":"No");
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("\n\n{0} sedang menjemput penumpang\n", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("\n\n{0} selesai mengantar penumpang\n", DriverName);
        }
    }
}
