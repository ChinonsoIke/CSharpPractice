using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            // add new trace listener
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));

            //enable autoflush of buffer
            Trace.AutoFlush= true;

            Debug.WriteLine("I C U");
            Trace.WriteLine("I 4 C U");

            var builder= new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",
                    optional: true, reloadOnChange: true);

            IConfigurationRoot configuration= builder.Build();

            var ts= new TraceSwitch(
                displayName: "PacktSwitch",
                description: "This switch is set via a json config."
            );

            configuration.GetSection("PacktSwitch").Bind(ts);

            Trace.WriteLineIf(ts.TraceError, "Trace error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");
        }
    }
}
