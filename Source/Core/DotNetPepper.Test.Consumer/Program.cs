using System;
using DotNetPepper.Test.Publisher;
using DotNetPepper.Test.Publisher.Folder1.Folder2.Folder3;

namespace DotNetPepper.Test.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleStaticClass.DoThing();
            NestedStaticClass.Hi();
            try
            {
                NestedStaticClass.ThrowException(); // Just to show that you can debug it
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            Console.ReadKey();
        }
    }
}
