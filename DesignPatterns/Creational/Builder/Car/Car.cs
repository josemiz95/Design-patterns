namespace Builder.Car
{
    public enum CarType
    {
        Sedan,
        Crossover
    }

    public class Car
    {
        public CarType Type;
        public int WheelSize;

        public override string ToString() => $"{nameof(Type)}: {Type} and {nameof(WheelSize)}: {WheelSize}";
    }
}
