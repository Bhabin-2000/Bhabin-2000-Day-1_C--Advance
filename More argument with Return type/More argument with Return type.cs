using System;

namespace More_argument_with_Return_type
{
    public delegate string No_Retun(string Name1, string name2);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("More_argument_with_Return_type");
            string Firstname = "Bhabin ";
            string secondname = "C.R Dhas";
            var Name_Print = new No_Retun(Print);
            Console.WriteLine($"\n Your Name is :{Name_Print.Invoke(Firstname, secondname)} ");
          
            Console.ReadKey();
        }
         static string Print(string name1, string name2)
        {
           return( name1 + name2);
        }
    }
}
