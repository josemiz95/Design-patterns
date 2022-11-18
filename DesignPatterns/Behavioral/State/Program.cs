namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.Run();
        }
    }

    public static class Demo
    {
        public static void Run()
        {
            var swicth = new Switch();

            swicth.On();
            swicth.Off();
        }
    }
}
