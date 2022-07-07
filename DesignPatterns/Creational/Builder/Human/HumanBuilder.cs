namespace Builder.Human
{
    public sealed class HumanBuilder: FunctionalBuilder<Human, HumanBuilder>
    {
        public HumanBuilder Called(string name) => Do(p => p.Name = name);
    }
}
