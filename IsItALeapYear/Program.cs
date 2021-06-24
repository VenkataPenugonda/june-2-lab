using System;

namespace IsItALeapYear.Services
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application to check if an year is leap year");
        }
        public bool IsItALeapYear(int year)
        {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        }
    }
}
