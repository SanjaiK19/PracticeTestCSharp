using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Temporary export lifecycle
//Destructors, garbage collection and cleanup

//An export tool creates many short-lived objects and writes a local report file.

//Your task
//Create an ExportTracker class with constructor and finalizer messages, and produce a batch of short-lived tracker objects.
//Write a small report using a file-writing resource that is disposed deterministically.
//Observe normal execution; optionally perform forced garbage collection in a separately labelled experiment and record finalizer observations.
//Submit observation notes about timing and repeatability; the report file must be closed without relying on a finalizer.
namespace C_PracticeTest
{
    public class ExportTracker
    {
        public ExportTracker()
        {
            Console.WriteLine("ExportTracker created.");
        }
        ~ExportTracker()
        {
            Console.WriteLine("ExportTracker finalized.");
        }
    }
    public class TemporaryExportLifecycle
    {
        public static void Main(string[] args)
        {
            // Create a batch of short-lived ExportTracker objects
            for (int i = 0; i < 10; i++)
            {
                ExportTracker tracker = new ExportTracker();
                // Simulate some work with the tracker
                Task.Delay(100).Wait();
            }
            // Write a small report using a file-writing resource that is disposed deterministically
            using (var writer = new System.IO.StreamWriter("report.txt"))
            {
                writer.WriteLine("Export report generated.");
            }
            // Optionally perform forced garbage collection
            Console.WriteLine("Forcing garbage collection...");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Program completed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
