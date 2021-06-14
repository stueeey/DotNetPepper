namespace DotNetPepper.Tests.Publisher
{
    public class ClassWhichChangesItsBehaviourBasedOnFloom
    {
#if FLOOM
        public string GetSentiment() => "I loooove floom";
#else
        public string GetSentiment() => "I abhor floom";
#endif
    }
}