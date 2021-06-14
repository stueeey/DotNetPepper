using System.Reflection;

namespace DotNetPepper.Tests.Publisher
{
    public static class SimpleStaticClass
    {
        public static string GetThing() { return $"Hello from {Assembly.GetExecutingAssembly().GetName().Name}"; }
    }
}
