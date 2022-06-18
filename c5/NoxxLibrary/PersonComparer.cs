using System.Collections.Generic;

namespace NoxxLibrary.Shared
{
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            // compare names by length
            int result = x.Name.Length.CompareTo(y.Name.Length);

            // if length equal then compare by name
            if(result == 0){
                return x.Name.CompareTo(y.Name);
            }

            return result;
        }
    }
}