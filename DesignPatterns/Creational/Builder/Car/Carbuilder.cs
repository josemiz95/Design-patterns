namespace Builder.Car
{
    using System;

    public class Carbuilder
    {
        private class Implemtation : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
        {
            private Car car = new Car();

            public Car Build() => car;

            public ISpecifyWheelSize OfType(CarType type)
            {
                car.Type = type;
                return this;
            }

            public IBuildCar WithWheels(int size)
            {
                switch (car.Type)
                {
                    case CarType.Crossover when size < 17 || size > 20:
                    case CarType.Sedan when size < 15 || size > 17:
                        throw new ArgumentException($"Wrong size for {car.Type}");
                }

                car.WheelSize = size;
                return this;
            }
        }

        public static ISpecifyCarType New = new Implemtation();
    }
}
