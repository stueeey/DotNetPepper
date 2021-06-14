namespace DotNetPepper.Tests.Publisher
{
    internal partial class PartialClass
    {
        public int Counter { get; private set; }

        public string Value { get; private set; }

        partial void PartialMethodWhichChangesValue(string value);

        public void ChangeValue(string value) => PartialMethodWhichChangesValue(value);
    }
}