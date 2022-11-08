using System;

namespace Observer.PersonObserver
{
    public abstract class Event { }

    public class FallsIllEvent : Event
    {
        public string Name;
    }

    public class EventSubscription : IDisposable
    {
        private Person person;
        private IObserver<Event> Observer;

        public EventSubscription(Person person, IObserver<Event> observer)
        {
            this.person = person;
            Observer = observer;
        }

        public void OnNext(Event value) => Observer.OnNext(value);

        public void Dispose() => person.UnSubscribe(this);
    }
}
