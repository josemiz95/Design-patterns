using System;
using System.Collections.Generic;

namespace Observer.PersonObserver
{
    public class Person : IObservable<Event>
    {
        private readonly HashSet<EventSubscription> subscriptions = new HashSet<EventSubscription>();

        public IDisposable Subscribe(IObserver<Event> observer)
        {
            var subscription = new EventSubscription(this, observer);
            subscriptions.Add(subscription);
            return subscription;
        }

        public void UnSubscribe(EventSubscription subscription)
        {
            subscriptions.Remove(subscription);
        }

        public void CatchACold()
        {
            foreach (var sub in subscriptions)
                sub.OnNext(new FallsIllEvent { Name = "Me" });
        }        
    }

    public class FallsIllEventHandler : IObserver<Event>
    {
        public void OnCompleted() => Console.WriteLine("Finished");

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Event value)
        {
            if (value is FallsIllEvent args)
                Console.WriteLine($"A doctor has been called By {args.Name}");
        }
    }
}
