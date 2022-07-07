namespace Builder.Human
{
    public class Human
    {
        public string Name, Position;
        public override string ToString()
            => $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
    }
}
