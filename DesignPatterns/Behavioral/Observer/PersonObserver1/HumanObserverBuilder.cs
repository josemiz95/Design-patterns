using System;

namespace Observer.PersonObserver1
{
    class HumanObserverBuilder
    {
        private HumanObserver _human;

        public HumanObserverBuilder()
        {
            _human = new HumanObserver();
        }

        public HumanObserver Build() => _human;

        public void addEventHandler(EventHandler<FallsIllEventArgs> eventHandler) => _human.FallsIll+=eventHandler;

        public static implicit operator HumanObserver(HumanObserverBuilder personBuilder) => personBuilder.Build();
    }

    public class EventHandlers
    {
        public static void EventHandler1(object sender, FallsIllEventArgs eventArgs) => Console.WriteLine($"A doctor has been called by {eventArgs.Name}");
    }
}
