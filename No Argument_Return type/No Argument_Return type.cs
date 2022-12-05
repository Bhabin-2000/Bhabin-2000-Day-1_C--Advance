using System;

namespace Argument_Delegate
{
    public delegate string ArgumentDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nArgument not  Passing Delegates return Type.\n");

            var adding = new ArgumentDelegate(add);         
            Console.WriteLine(adding.Invoke());

            Console.ReadKey();


        }
        static string add( )
        {
            string notes = "STRING Return";

            return notes;
        }
    }
}
