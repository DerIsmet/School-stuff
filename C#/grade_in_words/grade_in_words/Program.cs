using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade_in_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grade;
            string gradeinwords;

            Console.Write("Type in a grade between A-F: ");
            gradeinwords = Console.ReadLine();
            grade = Convert.ToString(gradeinwords);

            switch(grade)
            {
                case "A": gradeinwords = "very good"; break;
                case "B": gradeinwords = "good"; break;
                case "C": gradeinwords = "satisfying"; break;
                case "D": gradeinwords = "sufficient"; break;
                case "E": gradeinwords = "not enough"; break;
                case "F": gradeinwords = "insufficient"; break;
                default: gradeinwords = "not existing"; break;
            }
            Console.WriteLine("Your grade is " + gradeinwords+".");
            Console.ReadKey();

        }
    }
}
