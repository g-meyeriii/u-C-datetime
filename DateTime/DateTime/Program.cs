using System;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1977,7,15);

            Console.WriteLine("My birthday is  {0}", dateTime);

            //Write today on screen
            Console.WriteLine(DateTime.Today);
            // Write current time 
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();

            DateTime tomorrow = GetTomorrow();

            Console.WriteLine("Tomorrow will be {0}", tomorrow);

            Console.WriteLine(DateTime.Today.DayOfWeek);

            Console.WriteLine(GetFirstDayOfYear(1977));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000: {0}",  days);
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("Days in Feb 2001: {0}", days);
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in Feb 2004: {0}", days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}",now.Minute);

            DateTime hour = DateTime.Now;
            DateTime min = DateTime.Now;
            DateTime sec = DateTime.Now;

            Console.WriteLine("The time is {0} o'clock {1} minuted and {2} seconds", hour.Hour,min.Minute,sec.Second);

            Console.WriteLine("Write a date in this format yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);

                Console.WriteLine("Days passed since: {0}" , daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            Console.WriteLine("Input your birthday in this format yyyy-mm-dd");
            string birthDay = Console.ReadLine();
            if (DateTime.TryParse(birthDay, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);

                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }


            Console.ReadLine();
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
} 
