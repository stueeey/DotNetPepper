using FluentAssertions;

namespace DotNetPepper.Tests.Helpers
{
    public static class ReflectionHelpers
    {
        internal static void ThisAssemblyShouldHaveDefinedTypeNamed(string name, string because = null) => typeof(SimpleClassInjectionTests).Assembly.DefinedTypes.Should().Contain(t => t.Name == name, because);
        internal static void ThisAssemblyShouldNotHaveDefinedTypeNamed(string name, string because = null) => typeof(SimpleClassInjectionTests).Assembly.DefinedTypes.Should().NotContain(t => t.Name == name, because);
    }
}