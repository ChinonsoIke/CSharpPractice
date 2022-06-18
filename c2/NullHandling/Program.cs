using System;
#nullable enable

namespace NullHandling
{
    class Address
    {
        public string? Building;
        public string City=string.Empty, Street=string.Empty, Region=string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int? nullInt= null;
            Console.WriteLine(nullInt);
            Console.WriteLine(nullInt.GetValueOrDefault());
            nullInt= 7;
            Console.WriteLine(nullInt);
            Console.WriteLine(nullInt.GetValueOrDefault());

            // var Address= new Address();
            Address address= new ();
            address.Building= null;
            address.City= "Joburg";
            address.Region= "jos";
            address.Street= "adetutu";

            Console.WriteLine(address);
        }
    }
}
