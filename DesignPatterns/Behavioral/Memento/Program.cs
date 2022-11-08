using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.Restore();

            Demo.UndoRedo();
        }
    }

    public static class Demo
    {
        public static void Restore()
        {
            Console.WriteLine("RESTORE TEST");

            var ba = new BankAccount(100);
            var m1 = ba.Deposit(50); // 150
            var m2 = ba.Deposit(25); // 175
            Console.WriteLine(ba);

            // restore to m1
            ba.Restore(m1);
            Console.WriteLine(ba);

            ba.Restore(m2);
            Console.WriteLine(ba);
        }

        public static void UndoRedo()
        {
            Console.WriteLine("UNDO REDO TEST");

            var ba = new BankAccount(100);
            ba.Deposit(50); // 150
            ba.Deposit(25); // 175
            Console.WriteLine(ba);

            ba.Undo();
            Console.WriteLine($"Undo 1: {ba}");
            ba.Undo();
            Console.WriteLine($"Undo 2: {ba}");
            ba.Redo();
            Console.WriteLine($"Redo 2: {ba}");
        }
    }
}
