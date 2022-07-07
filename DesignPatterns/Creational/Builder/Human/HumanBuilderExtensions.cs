namespace Builder.Human
{
    public static class HumanBuilderExtensions
    {
        public static HumanBuilder WorksAs(this HumanBuilder builder, string position) 
            => builder.Do(p => p.Position = position);
    }
}
