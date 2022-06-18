using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunTimes();
            // decimal amount= RunVatCalc();
            // WriteLine($"Total amount after VAT is {amount}");
            // CallCardinalToOrdinal();
            // CallFactorial();
            CallFibImperative();
            CallFibFunctional();
        }

        static void Times(int num)
        {
            WriteLine($"Times Table for {num}");
            for(int i=1; i < 13; i++){
                WriteLine($"{i} * {num} = {i * num}");
            }
        }

        static void RunTimes()
        {
            bool isNumber;
            do{
                Write("Enter a number between 0 and 255: ");
                isNumber= byte.TryParse(ReadLine(), out byte num);

                if(isNumber){
                    Times(num);
                }else{
                    WriteLine("Invalid input");
                }
            }while(isNumber);
        }

        static decimal CalculateTax(decimal amount, string region)
        {
            decimal vat;

            switch(region){
                case "uk":
                    vat= amount * 0.07M;
                    break;
                case "us":
                    vat= amount * 0.07M;
                    break;
                case "hg":
                    vat= amount * 0.27M;
                    break;
                case "ca":
                    vat= amount * 0.17M;
                    break;
                default:
                    vat= 0;
                    break;
            }

            return vat;
        }

        static decimal RunVatCalc()
        {
            bool isValid;
            do{
                Write("Enter price of product: ");
                string price= ReadLine();
                Write("Enter region: ");
                string region= ReadLine();

                isValid= decimal.TryParse(price, out decimal amount) && (region.Length == 2);

                if(isValid){
                    decimal vat= CalculateTax(amount, region);
                    return amount + vat;
                }
            }while(isValid);
            return 0.00M;
        }

        /// <summary>
        /// converts a cardinal number to an ordinal
        /// </summary>
        /// <param name="n">nis a cardinal value, eg 1,2,3,...,n</param>
        /// <returns>returns an ordinal value, eg 1st, 2nd, 3rd,..., nth</returns>
        static string CardinalToOrdinal(int n)
        {
            switch(n)
            {
                case 11:
                case 12:
                case 13:
                    return $"{n}th";
                default:
                    int lastDigit= n % 10;
                    string suffix= lastDigit switch{
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{n}{suffix}";
            }
        }

        static void CallCardinalToOrdinal()
        {
            for(int i=0; i <= 40; i++){
                string num= CardinalToOrdinal(i);
                Write($"{num}\t");
                WriteLine(int.Parse(num.Substring(0, num.Length-2)));
            }
            WriteLine();
        }

        /// <summary>
        /// recursively factorializes a long value
        /// </summary>
        /// <param name="n">n is a long value</param>
        /// <returns>returns factorialized value of n</returns>
        static long Factorial(long n)
        {
            if(n == 1){
                return 1;
            }
            checked{
                return n * Factorial(n-1);
            }
        }

        /// <summary>
        /// calls the Factorial() function
        /// </summary>
        static void CallFactorial()
        {
            bool isValid;
            do{
                Write("Input a number: ");
                isValid= long.TryParse(ReadLine(), out long num);

                if(isValid){
                    try{
                        WriteLine($"The factorial of {num} is {Factorial(num)}");
                    }catch(OverflowException){
                        WriteLine($"The factorial of {num} exceeds the 64bit long size");
                    }
                }
            }while(isValid);
        }

        static int FibImperative(int term)
        {
            if(term == 1){
                return 0;
            }else if(term == 2){
                return 1;
            }else{
                return FibImperative(term - 1) + FibImperative(term - 2);
            }
        }

        static void CallFibImperative()
        {
            for(int i=1; i <= 10; i++){
                WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibImperative(i):N0}");
            }
        }

        static int FibFunctional(int term) =>
            term switch
            {
                1 => 0,
                2 => 1,
                _ => FibFunctional(term - 1) + FibFunctional(term - 2)
            };

        static void CallFibFunctional()
        {
            for(int i=1; i <= 15; i++){
                WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibFunctional(i):N0}");
            }
        }
    }
}
