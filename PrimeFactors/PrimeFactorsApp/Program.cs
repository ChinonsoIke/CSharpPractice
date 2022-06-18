using System;
using static System.Console;
using PrimeFactorsLib;

namespace PrimeFactorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string result= CallCheckPrime();
            WriteLine(result);
        }

        static string CallCheckPrime()
        {
            WriteLine("Input a whole number to check its prime factors: ");
            bool isValid;

            do{
                isValid= int.TryParse(ReadLine(), out int number);
                if(isValid){
                    var prime= new PrimeFactors();
                    string result= prime.CheckPrime(number);
                    WriteLine($"Prime factors of {number}:");
                    return result;
                }
            }while(isValid);

            return "Could not check prime factors";
        }
    }
}
