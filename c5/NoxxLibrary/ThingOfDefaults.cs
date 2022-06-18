using System;
using System.Collections.Generic;

namespace NoxxLibrary.Shared
{
    public class ThingOfDefaults
    {
        public static int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;

        public ThingOfDefaults()
        {
            Population= default;
            When= default;
            Name= default;
            People= default;
        }
    }
}