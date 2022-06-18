using System;
using static System.Console;
using static System.Convert;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // long num1= 3_000_000;
            // int num2= (int)num1;
            // WriteLine(num2);
            // double num3= 3.9;
            // int num4= ToInt32(num3);
            // WriteLine(num4);
            // int num5= ToInt32(Math.Round(num3, 0, MidpointRounding.ToZero));
            // WriteLine(num5);
            // WriteLine(num5.ToString());

            // allocate array of 128 bytes
            byte[] binaryObject= new byte[128];
            
            // populate array with random bytes
            (new Random()).NextBytes(binaryObject);
            WriteLine("Binary Object as bytes(Hex):");
            for(int i=0; i < binaryObject.Length; i++){
                Write($"{binaryObject[i]:X} ");
            }
            WriteLine();

            WriteLine("Binary Object as bytes(Decimal):");
            for(int i=0; i < binaryObject.Length; i++){
                Write($"{binaryObject[i]} ");
            }
            WriteLine();

            WriteLine("Binary Object as Base64String:");
            string encoded= ToBase64String(binaryObject);
            WriteLine(encoded);

            int age= int.Parse("26");
            DateTime birthday= DateTime.Parse("4 July 1996");
            WriteLine($"You're {age}, you were born on {birthday}");

            Write("How old are you? ");
            int userAge;
            string input= ReadLine();
            if(int.TryParse(input, out userAge)){
                WriteLine($"I see, you look good for {userAge}");
            }else{
                WriteLine("Could not parse input");
            }
        }
    }
}
