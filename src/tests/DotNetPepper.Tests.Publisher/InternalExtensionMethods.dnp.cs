namespace DotNetPepper.Tests.Publisher
{
    internal static class InternalExtensionMethods
    {
        internal static bool IsNullOrWhiteSpace(this string candidate) => string.IsNullOrWhiteSpace(candidate);
    }
}