using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double userinputa;
            double userinputb;
            double result;
            char inputmath;

            Console.Write("Please type number a in: ");
            userinputa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please type number b in: ");
            userinputb = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Choose Operator +, -, * or /: ");
            inputmath = Convert.ToChar(Console.ReadLine());
            switch (inputmath)
            {
                case '+': result = userinputa + userinputb; break;
                case '-': result = userinputa - userinputb; break;
                case '*': result = userinputa * userinputb; break;
                case '/': result = userinputa / userinputb; break;
                default: result = 69; break;
            }
            Console.WriteLine("The result is: " + userinputa + " "+inputmath+" " + userinputb + " = " + result + "");
            Console.ReadKey();
        }
    }
}
