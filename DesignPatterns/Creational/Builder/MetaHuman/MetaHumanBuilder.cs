namespace Builder.MetaHuman
{
    public class MetaHumanBuilder
    {
        protected MetaHuman metaHuman = new MetaHuman();

        public HumanDataBuilder Human => new HumanDataBuilder(metaHuman);

        public PowerBuilder Power => new PowerBuilder(metaHuman);

        public static implicit operator MetaHuman(MetaHumanBuilder builder) => builder.metaHuman;
    }
}
