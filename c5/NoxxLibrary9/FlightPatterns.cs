using System;

namespace NoxxLibrary.Shared
{
    public class BusinessClassPassenger
    {
        public override string ToString()
        {
            return $"Business Class";
        }
    }

    public class FirstClassPassenger
    {
        public int Airmiles { get; set; }

        public override string ToString()
        {
            return $"First class with {Airmiles:N0} air miles";
        }
    }

    public class CoachClassPassenger
    {
        public int CarryOnKg { get; set; }

        public override string ToString()
        {
            return $"Coach class with {CarryOnKg:N2} carry-on kg";
        }
    }
}
