using System;

namespace More_then_one_argument_noreturn_type
{
    public delegate void No_Retun(string Name1, string name2);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("More_then_one_Argument_no_Return_type");
            string Firstname = "Bhabin ";
            string secondname = "C.R Dhas";
            var Name_Print = new No_Retun(Print);
            Name_Print.Invoke(Firstname, secondname);


            Console.ReadKey();
        }
        static void Print(string name1,string name2)
        {
            Console.WriteLine($"Your Name is : {name1 +name2}");
        }
    }
}
