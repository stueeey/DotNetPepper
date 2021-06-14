using System.Reflection;
using DotNetPepper.Tests.Helpers;
using FluentAssertions;
using DotNetPepper.Tests.Publisher;
using Xunit;

namespace DotNetPepper.Tests
{
    public class ExtensionMethodInjectionTests
    {
        [Fact]
        public void ImportedExtensionMethods_ShouldBeAvailableAndNotPublic()
        {
            ReflectionHelpers.ThisAssemblyShouldHaveDefinedTypeNamed(nameof(InternalExtensionMethods));
            ((string) null).IsNullOrWhiteSpace().Should().BeTrue();
            "   ".IsNullOrWhiteSpace().Should().BeTrue();
            "g    g".IsNullOrWhiteSpace().Should().BeFalse();
            typeof(InternalExtensionMethods).GetMethod(nameof(InternalExtensionMethods.IsNullOrWhiteSpace), BindingFlags.Static | BindingFlags.NonPublic).IsPublic.Should().BeFalse();
        }
    }
}