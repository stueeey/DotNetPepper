namespace DotNetPepper.Tests.Publisher
{
    public abstract class ProtectedClass
    {

        protected ProtectedClass(string bloop)
        {
            Bloop = bloop;
        }

        public string Bloop { get; }
    }
}