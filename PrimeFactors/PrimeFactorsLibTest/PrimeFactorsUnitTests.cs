using System;
using Xunit;
using PrimeFactorsLib;

namespace PrimeFactorsLibTest
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void Test10()
        {
            // arrange
            int a= 10;
            string expected= "2,5,";
            var prime= new PrimeFactors();

            // act
            string result= prime.CheckPrime(a);

            // assert
            AssemblyLoadEventArgs.Equals(result, expected);
        }

        [Fact]
        public void Test54()
        {
            // arrange
            int a= 54;
            string expected= "2,3,3,3,";
            var prime= new PrimeFactors();

            // act
            string result= prime.CheckPrime(a);

            // assert
            AssemblyLoadEventArgs.Equals(result, expected);
        }
    }
}
