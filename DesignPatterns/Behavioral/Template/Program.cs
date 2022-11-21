using System;
using Template.GameTemplate;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.PlayChess();
        }
    }

    public static class Demo
    {
        public static void PlayChess()
        {
            var chess = new Chess();
            chess.Run();
        }
    }
}
