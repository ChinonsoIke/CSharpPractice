using System;

namespace NoxxLibrary.Shared
{
    public partial class Person
    {
        public string GetOrigin
        {
            get
            {
                return $"{Name} is from {HomePlanet}";
            }
        }

        public string Greeting => $"{Name} says hello";

        public int Age => DateTime.Today.Year - DateOfBirth.Year;

        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index]= value;
            }
        }
    }
}