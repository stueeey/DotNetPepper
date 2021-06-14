using DotNetPepper.Tests.Helpers;
using DotNetPepper.Tests.Publisher;
using DotNetPepper.Tests.Publisher.Folder1.Folder2.Folder3;
using FluentAssertions;
using Xunit;

namespace DotNetPepper.Tests
{
    public class SimpleClassInjectionTests
    {
        [Fact]
        public void StaticClass_ShouldWorkAsIfItIsDefinedWithinThisProject()
        {
            ReflectionHelpers.ThisAssemblyShouldHaveDefinedTypeNamed(nameof(SimpleStaticClass));
            SimpleStaticClass.GetThing().Should().Be("Hello from DotNetPepper.Tests");
            typeof(SimpleStaticClass).Namespace.Should().Be("DotNetPepper.Tests.Publisher");
        }
        
        [Fact]
        public void NestedStaticClass_ShouldWorkAsIfItIsDefinedWithinThisProject()
        {
            ReflectionHelpers.ThisAssemblyShouldHaveDefinedTypeNamed(nameof(NestedStaticClass));
            NestedStaticClass.Hi().Should().Be("Hi from class in nested folder structure");
            typeof(NestedStaticClass).Namespace.Should().Be("DotNetPepper.Tests.Publisher.Folder1.Folder2.Folder3");
        }
        
        [Fact]
        public void InternalInstanceClass_ShouldWorkAsIfItIsDefinedWithinThisProject()
        {
            ReflectionHelpers.ThisAssemblyShouldHaveDefinedTypeNamed(nameof(InternalInstanceClass));
            var instance = new InternalInstanceClass();
            instance.GetName().Should().Be(nameof(InternalInstanceClass));
            instance.GetType().IsVisible.Should().BeFalse("This type should not be visible to consumers of this project");
            typeof(InternalInstanceClass).Namespace.Should().Be("DotNetPepper.Tests.Publisher");
        }


        private class MyProtectedClassDescendant : ProtectedClass
        {
            public MyProtectedClassDescendant() : base("BLOOP!")
            {
            }
        }
        
        [Fact]
        public void ProtectedClass_ShouldWorkAsIfItIsDefinedWithinThisProject()
        {
            ReflectionHelpers.ThisAssemblyShouldHaveDefinedTypeNamed(nameof(ProtectedClass));
            var bloop = new MyProtectedClassDescendant();
            bloop.Bloop.Should().Be("BLOOP!");
            bloop.GetType().BaseType.Should().Be(typeof(ProtectedClass));
            bloop.GetType().IsVisible.Should().BeFalse("This type should not be visible to consumers of this project");
            typeof(MyProtectedClassDescendant).Namespace.Should().Be("DotNetPepper.Tests");
        }
        
        [Fact]
        public void ClassWhichIsNotExposedViaDotNetPepper_ShouldNotBeVisible()
        {
            ReflectionHelpers.ThisAssemblyShouldNotHaveDefinedTypeNamed("IgnoreMe");
        }
    }
}