using DotNetPepper.Tests.Helpers;
using DotNetPepper.Tests.Publisher;
using FluentAssertions;
using Xunit;

namespace DotNetPepper.Tests.Publisher
{
    internal partial class PartialClass
    {
        public void Increment() => Counter++;
        
        partial void PartialMethodWhichChangesValue(string value)
        {
            Value = value;
        }
    }
}

namespace DotNetPepper.Tests
{

    public class PartialClassInjectionTests
    {
        [Fact]
        public void ImportedPartialClass_ShouldHaveCounterAndIncrementDefined()
        {
            ReflectionHelpers.ThisAssemblyShouldHaveDefinedTypeNamed(nameof(PartialClass));
            var instance = new PartialClass();
            instance.Counter.Should().Be(0);
            instance.Increment();
            instance.Counter.Should().Be(1);
        }
        
        [Fact]
        public void ImportedPartialClass_ShouldCallPartialImplementation()
        {
            var instance = new PartialClass();
            instance.Value.Should().BeNull();
            instance.ChangeValue("Hi Mum");
            instance.Value.Should().Be("Hi Mum");
        }
    }
}