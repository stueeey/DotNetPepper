using DotNetPepper.Tests.Helpers;
using DotNetPepper.Tests.Publisher;
using FluentAssertions;
using Xunit;

namespace DotNetPepper.Tests
{
    public class CompileFlagTests
    {
        [Fact]
        public void WhenClassesAreConditionallyDefined_CodeShouldRespectConsumingProjectsCompileFlags()
        {
            // Note that FLOOM is defined in the project file
            ReflectionHelpers.ThisAssemblyShouldHaveDefinedTypeNamed(nameof(ClassWhichOnlyExistsWhenFloomIsDefined));
            var floomExpert = new ClassWhichChangesItsBehaviourBasedOnFloom();
            floomExpert.GetSentiment().Should().Be("I loooove floom");
        }
    }
}