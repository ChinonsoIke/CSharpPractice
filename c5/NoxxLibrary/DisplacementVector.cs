using System;

namespace NoxxLibrary.Shared
{
    public struct DisplacementVector
    {
        public int X, Y;

        public DisplacementVector(int aX, int aY)
        {
            X= aX;
            Y= aY;
        }

        public static DisplacementVector operator + (DisplacementVector obj1, DisplacementVector obj2)
        {
            var obj3= new DisplacementVector {
                X= obj1.X + obj2.X,
                Y= obj1.Y + obj2.Y
            };
            return obj3;
        }
    }
}