using System;

namespace DotNetPepper.Test.Publisher.Folder1.Folder2.Folder3
{
    public static class NestedStaticClass
    {
        public static void Hi() => Console.WriteLine("Hi from class in nested folder structure");

        public static void ThrowException() => throw new InvalidOperationException("Blarg I'm Dead");
    }
}
