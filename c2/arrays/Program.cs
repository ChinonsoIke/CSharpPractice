using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names;
            names= new string[4];

            names[0]= "James";
            names[1]= "Emma";
            names[2]= "Chisom";
            names[3]= "Ayo";

            for(int i=0; i < names.Length; i++){
                Console.WriteLine($"{names[i]}");
            }
        }
    }
}
