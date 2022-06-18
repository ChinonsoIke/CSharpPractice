using System;
using static System.Console;
using System.Reflection;

namespace WorkingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Getting Assembly Metadata");
            Assembly assembly= Assembly.GetEntryAssembly();
            
            WriteLine($"Fullname: {assembly.FullName}");
            WriteLine($"Location: {assembly.Location}");

            var attributes= assembly.GetCustomAttributes();

            WriteLine("Attributes");
            foreach(Attribute a in attributes){
                WriteLine(a.GetType());
            }

            var version= assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            var company= assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            WriteLine($"Version: {version.InformationalVersion}");
            WriteLine($"Company: {company.Company}");
        }
    }
}
