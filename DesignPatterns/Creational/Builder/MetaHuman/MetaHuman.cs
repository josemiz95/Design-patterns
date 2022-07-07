namespace Builder.MetaHuman
{
    public class MetaHuman
    {
        // Human
        public string Name, Address;

        // Power
        public string Power;
        public int Energy;

        public override string ToString()
        {
            return $"{nameof(Name)} : {Name}" +
                $"\n{nameof(Address)} : {Address}" +
                $"\n{nameof(Power)} : {Power}" +
                $"\n{nameof(Energy)} : {Energy}";
        }
    }
}
