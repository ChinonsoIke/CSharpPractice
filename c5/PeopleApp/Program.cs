using System;
using static System.Console;
using NoxxLibrary.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var bob= new Person();
            bob.Name= "Bom Marley";
            bob.FavouriteWonder= WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.GreatPyramidOfGiza;
            bob.DateOfBirth= new DateTime(1968, 2, 12);
            bob.Children.Add(new Person { Name= "Emeka" });
            bob.Children.Add(new Person { Name= "Ike" });

            WriteLine(
                format: "{0} was born on {1}, and his favorite wonder of the ancient world is {2}.",
                arg0: bob.Name,
                arg1: bob.DateOfBirth,
                arg2: bob.FavouriteWonder
            );

            WriteLine(
                format: "{0} has {1} children, all from {2}: ",
                arg0: bob.Name,
                arg1: bob.Children.Count,
                arg2: bob.HomePlanet
            );

            for(int child=0; child < bob.Children.Count; child++){
                WriteLine($"    {bob.Children[child].Name}");
            }

            var alice= new Person
            {
                Name= "Alicin Wondaland",
                DateOfBirth= new DateTime(1234, 12, 02),
                FavouriteWonder= WondersOfTheAncientWorld.StatueOfZeusAtOlympia
            };

            WriteLine(
                format: "{0} is a {1} born on {2:dd MMMM, yyyy}.",
                arg0: alice.Name,
                arg1: Person.Species,
                arg2: alice.DateOfBirth
            );

            BankAccount.InterestRate= 0.12M;

            var jonesAccount= new BankAccount
            {
                AccountName= "MF Jones",
                Balance= 1200M
            };

            WriteLine(
                format: "{0} earned an interest of ${1} this quarter.",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate
            );

            var luke= new Person();
            WriteLine($"{luke.Name} registered on {luke.Instatiated}");

            var bruno= new Person("Bruno", "Mars");
            WriteLine($"{bruno.Name} is from {bruno.HomePlanet} and population is {ThingOfDefaults.Population}");

            var noxx= GetTuple("Noxx", 26);
            WriteLine($"{noxx.Name} is {noxx.Age} years old.");

            (string name, int age)= GetTuple("Amaka", 29); //deconstructing tuple into separate variables
            WriteLine($"{name} is {age} years old");

            var sam= new Person
            {
                Name= "Samwell Tarly",
                DateOfBirth= new DateTime(1920, 02, 12)
            };
            sam.Children.Add(new Person { Name= "Jamie Tarly" });
            sam.Children.Add(new Person { Name= "Suzie Tarly" });

            WriteLine($"{sam.GetOrigin}");
            WriteLine($"{sam.Age}");
            WriteLine($"{sam.Greeting}");

            WriteLine(
                format: "{0}'s children are {1} and {2}",
                arg0: sam.Name,
                arg1: sam.Children[0].Name,
                arg2: sam.Children[1].Name
            );

            WriteLine(
                format: "{0}'s children are {1} and {2}",
                arg0: sam.Name,
                arg1: sam[0].Name,
                arg2: sam[1].Name
            );

            object[] passengers= {
                new FirstClassPassenger {Airmiles= 1_607},
                new FirstClassPassenger {Airmiles= 12_203},
                new FirstClassPassenger(),
                new BusinessClassPassenger(),
                new CoachClassPassenger {CarryOnKg= 23},
                new CoachClassPassenger {CarryOnKg= 45}
            };

            foreach(object passenger in passengers){
                decimal flightCost= passenger switch
                {

                    FirstClassPassenger p => p.Airmiles switch
                    {
                        > 10000 => 1500M,
                        > 2000 => 800M,
                        _ => 500M
                    },

                    BusinessClassPassenger => 2500M,

                    CoachClassPassenger p => p.CarryOnKg switch
                    {
                        > 40 => 500M,
                        _ => 300M
                    },

                    _ => 450M
                };

                WriteLine($"Flight costs ${flightCost:N2} for {passenger}");

                var person1= new ImmutablePerson{
                    FirstName= "Emeka",
                    LastName= "Ike"
                };

                var car= new ImmutableVehicle
                {
                    Brand= "Mazda",
                    Color= "Black",
                    Wheels= 4
                };

                var repaintedCar= car with {Color= "Red"};

                WriteLine($"Car was {car.Color}, and now it's {repaintedCar.Color}.");
            }

            var animal1= new ImmutableAnimal("Kamaru", "Great Dane");
            var (who, what)= animal1;

            WriteLine($"{who} is a {what}");*/

            var mary= new Person {Name="Mary"};
            var emeka= new Person {Name="Emeka"};
            var nneka= new Person {Name="Nneka"};

            Person offspring1= mary.ProcreateWith(emeka);
            Person offspring2= Person.Procreate(emeka, nneka);
            Person offspring3= mary * nneka;

            var del1= new Person.DelDel(mary.DelMethod);
            WriteLine(del1("23"));

            mary.Shout+= Mary_Shout;

            mary.Poke();
            mary.Poke();
            mary.Poke();
            mary.Poke();

            Person[] people= 
            {
                new Person {Name= "Amaka"},
                new Person {Name= "Tinuke"},
                new Person {Name= "Ebube"},
                new Person {Name= "Yusuf"},
            };

            WriteLine("initial people array");
            foreach(Person person in people){
                WriteLine(person.Name);
            }

            WriteLine("Using Person's IComparable implementation to sort");
            Array.Sort(people);
            foreach(Person person in people){
                WriteLine(person.Name);
            }

            WriteLine("Using PersonComparers's ICompare<> implementation to sort");
            Array.Sort(people, new PersonComparer());
            foreach(Person person in people){
                WriteLine(person.Name);
            }

            var gen1= new GenericThing<int>();
            gen1.Data= 42;
            WriteLine(gen1.Process(42));

            var gen2= new GenericThing<string>();
            gen2.Data= "hey";
            WriteLine(gen2.Process("hello"));

            // var gen3= new GenericThing<Person>();
            // gen3.Data= new Person {Name="Emeka"};

            var obj1= new DisplacementVector {X=2, Y=4};
            var obj2= new DisplacementVector {X=-1, Y=12};
            var obj3= obj1 + obj2;

            WriteLine($"({obj3.X}, {obj3.Y})");

        }

        private static void Mary_Shout(object sender, EventArgs e)
        {
            Person p= (Person)sender;
            WriteLine($"{p.Name}'s anger level is {p.AngerLevel}");
        }
    }
}
