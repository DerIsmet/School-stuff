using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace how_many_days_does_your_month_have
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            int monthdays;
            int year;
            string monthwords;
            bool leapyear;

            Console.Write("Please type a month in number in: ");
            month = Convert.ToInt16(Console.ReadLine());
            monthdays = Convert.ToInt32(month);
            monthwords = Convert.ToString(month);
            Console.Write("Please type in a year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                leapyear = true;

                if (year % 100 == 0)
                {
                    if (year % 400 != 0)
                    {
                        leapyear = false;
                    }
                    else
                    {
                        leapyear = true;
                    }
                }
                else
                {
                    leapyear = true;
                }
            }
            else
            {
                leapyear = false;
            }
            if (leapyear == false)
            {
                switch (month)
                {
                    case 1: monthdays = 31; break;
                    case 2: monthdays = 28; break;
                    case 3: monthdays = 31; break;
                    case 4: monthdays = 30; break;
                    case 5: monthdays = 31; break;
                    case 6: monthdays = 30; break;
                    case 7: monthdays = 31; break;
                    case 8: monthdays = 31; break;
                    case 9: monthdays = 30; break;
                    case 10: monthdays = 31; break;
                    case 11: monthdays = 30; break;
                    case 12: monthdays = 31; break;
                    default: monthdays = 0; break;
                }
            }
            if (leapyear == true)
            {
                switch (month)
                {
                    case 1: monthdays = 31; break;
                    case 2: monthdays = 29; break;
                    case 3: monthdays = 31; break;
                    case 4: monthdays = 30; break;
                    case 5: monthdays = 31; break;
                    case 6: monthdays = 30; break;
                    case 7: monthdays = 31; break;
                    case 8: monthdays = 31; break;
                    case 9: monthdays = 30; break;
                    case 10: monthdays = 31; break;
                    case 11: monthdays = 30; break;
                    case 12: monthdays = 31; break;
                    default: monthdays = 0; break;
                }
            }
            switch (month)
            {
                case 1: monthwords = "January"; break;
                case 2: monthwords = "February"; break;
                case 3: monthwords = "March"; break;
                case 4: monthwords = "April"; break;
                case 5: monthwords = "May"; break;
                case 6: monthwords = "June"; break;
                case 7: monthwords = "July"; break;
                case 8: monthwords = "August"; break;
                case 9: monthwords = "September"; break;
                case 10: monthwords = "October"; break;
                case 11: monthwords = "November"; break;
                case 12: monthwords = "December"; break;
                default: monthwords = "not available"; break;
            }


            Console.WriteLine("The " + monthwords + " " + year + " has " + monthdays + " days.");

            Console.ReadKey();
        }
    }
}
