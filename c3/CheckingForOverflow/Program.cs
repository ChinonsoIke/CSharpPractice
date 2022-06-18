using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                WriteLine(2.9/0);
                checked{
                    int num1= int.MaxValue - 1;
                    WriteLine(num1);
                    num1++; WriteLine(num1);
                    num1++; WriteLine(num1);
                    num1++; WriteLine(num1);
                }
            }catch{
                WriteLine("There was an overflow, but I handled it like Courtois. :)");
            }
            
            // checked{
            //     int max = 500;
            //     for (byte i = 0; i < max; i++)
            //     {
            //         WriteLine(i);
            //     }
            // }

            int num= 1;
            object[] nums = new object[100];

            for(int i=0; i < 100; i++){
                if(((i+1) % 3 == 0) && ((i+1) % 5 == 0)){
                    nums[i]= "FizzBuzz";
                }else if((i+1) % 3 == 0){
                    nums[i]= "Fizz";
                }else if((i+1) % 5 == 0){
                    nums[i]= "Buzz";
                }else{
                    nums[i]= i+1;
                }
            }

            for(int i=0; i < nums.Length; i++){
                Write($"{nums[i]}, ");
            }
            WriteLine();
            WriteLine(3 << 2);
        }
    }
}
