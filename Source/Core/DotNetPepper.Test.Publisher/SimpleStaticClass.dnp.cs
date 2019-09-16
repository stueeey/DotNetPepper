using System;
using System.Reflection;

namespace DotNetPepper.Test.Publisher
{
    public static class SimpleStaticClass
    {
        public static void DoThing() { Console.WriteLine($"Hello from {Assembly.GetExecutingAssembly().GetName()}"); }
    }
}
