using System;
using System.Collections.Generic;

namespace NoxxLibrary.Shared
{
    public partial class Person : IComparable
    {
        public string Name;
        public const string Species= "Homo sapiens";
        public readonly string HomePlanet= "Earth";
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavouriteWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children= new List<Person>();
        public DateTime Instatiated;

        public event EventHandler Shout;
        public int AngerLevel;

        public Person()
        {
            Name= "Unknown";
            Instatiated= DateTime.Now;
        }

        public Person(string aName, string aHomePlanet)
        {
            Name= aName;
            HomePlanet= aHomePlanet;
            Instatiated= DateTime.Now;
        }

        public static Person Procreate(Person person1, Person person2)
        {
            var baby= new Person
            {
                Name= $"Baby of {person1} and {person2}"
            };

            person1.Children.Add(baby);
            person2.Children.Add(baby);

            return baby;
        }

        public Person ProcreateWith(Person person)
        {
            return Procreate(this, person);
        }

        public static Person operator * (Person person1, Person person2)
        {
            return Procreate(person1, person2);
        }

        public int DelMethod(string param)
        {
            return(int.Parse(param));
        }

        public delegate int DelDel(string param);

        public void Poke()
        {
            AngerLevel++;
            if(AngerLevel >= 3){
                // if there's already a delegate pointing to a method
                // then call the delegate
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }

        public int CompareTo(object obj)
        {
            Person other= (Person)obj;
            return Name.CompareTo(other.Name);
        }
    }
}
