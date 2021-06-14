using System;

namespace DotNetPepper.Tests.Publisher.Folder1.Folder2.Folder3
{
    public static class NestedStaticClass
    {
        public static string Hi() => "Hi from class in nested folder structure";

        public static void ThrowException() => throw new InvalidOperationException("Blarg I'm Dead");
    }
}
