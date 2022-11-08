using System;

namespace Observer.PersonObserver1
{
    public class FallsIllEventArgs
    {
        public string Name;
    }

    public class HumanObserver
    {
        public void CatchACold()
        {
            FallsIll?.Invoke(this,
              new FallsIllEventArgs { Name = "Josemi" });
        }

        public event EventHandler<FallsIllEventArgs> FallsIll;
    }
}
