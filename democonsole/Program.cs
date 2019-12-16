using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Data;


namespace democonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
            Process.Start(@"E:\projects\Roshni_Work\democonsole\normalconsole\bin\Debug\normalconsole.exe");
          //  Assembly asm = Assembly.LoadFrom(@"E:\projects\Roshni_Work\democonsole\democore2\bin\Debug\netcoreapp2.2\democore2.dll");

           //var asm = Assembly.LoadFrom(@"E:\projects\Roshni_Work\democonsole\democore2\bin\Debug\netcoreapp2.2\democore2.dll");

           // // Get all the test classes in the assembly
           // var testClassTypes = asm.GetTypes()
           //     .Where(t => t.CustomAttributes.Any(a => a.AttributeType.Name == "TestClassAttribute"));

           // foreach (var t in testClassTypes)
           // {

           //     // Get all the test methods in each test class
           //     var methods = t.GetMethods().Where(m => m.CustomAttributes
           //         .Any(a => a.AttributeType.Name == "TestMethodAttribute")
           //             && m.CustomAttributes.Any(a => a.AttributeType.Name == "PriorityAttribute"))
           //         .ToList();

           //     // Order the methods by priority
           //     var orderedMethods = methods
           //         .OrderBy(m =>
           //             m.CustomAttributes.Last(a => a.AttributeType.Name == "PriorityAttribute")
           //             .ConstructorArguments.First().Value
           //         );

           //     var methods_default = t.GetMethods().Where(m => m.CustomAttributes
           //        .Any(a => a.AttributeType.Name == "TestMethodAttribute")
           //            // && m.CustomAttributes.Any(a => a.AttributeType.Name == "PriorityAttribute")
           //            )
           //        .ToList();

           //     // A test class should have a parameterless constructor
           //     var tc = Activator.CreateInstance(t, null);

           //     // Run the ordered test methods
           //     foreach (var m in methods_default)
           //     {
           //         // Invoke the test method
           //         // An error will be thrown if it fails
           //         m.Invoke(tc, null);
           //     }
           // }



            // objUtility.WriteLog(LogEntity.LogType.EventLog, EventLogEnabled, filePath + LogEntity.LogType.EventLog.ToString(), "", "", "4)Start Executing the Dll of Telegram_Export_Automation");

    Process.Start(@"E:\projects\Roshni_Work\democonsole\democore2\bin\Debug\netcoreapp2.2\democore2.dll");
        }
    }
}
