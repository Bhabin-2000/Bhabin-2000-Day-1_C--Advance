using System;

namespace Delegate
{
    public delegate void DeligateDemo();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate");
            var printing = new DeligateDemo(print);
            printing.Invoke();

        }
        static void print()
        {
            Console.WriteLine("Demo Delegate");
        }
            
    }
}
