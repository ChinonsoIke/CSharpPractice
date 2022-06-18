using System;

namespace PrimeFactorsLib
{
    public class PrimeFactors
    {
        public string CheckPrime(int n)
        {
            string factors= "";
            int divisor= 2;

            while(n >= 2){
                if(n % divisor == 0){
                    factors += $"{divisor.ToString()},";
                    n = n / divisor;
                }else{
                    divisor++;
                }
            }

            return factors;
        }
    }
}
