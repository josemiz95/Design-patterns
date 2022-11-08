using System;

namespace Observer.PersonObserver
{
    public class PersonBuilder
    {
        private Person _person;

        public PersonBuilder()
        {
            _person = new Person();
        }

        public Person Build() => _person;

        public void addEventHandler(IObserver<Event> eventHandler) => _person.Subscribe(eventHandler);

        public static implicit operator Person(PersonBuilder personBuilder) => personBuilder.Build();
    }

}
