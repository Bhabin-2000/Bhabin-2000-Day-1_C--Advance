using System;

namespace Argument_Pass_No_return_type
{
    public delegate void No_Retun(string Name);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Argument_Pass_No_Return_Type");
            string name = "Bhabin";
            var Name_Print = new No_Retun(Print);
            Name_Print.Invoke(name);


            Console.ReadKey();
        }
        static void Print(string names)
        {
            Console.WriteLine($"Your Name is : {names}");
        }
    }

}
