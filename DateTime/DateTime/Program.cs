using System;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            //    DateTime dateTime = new DateTime(1977,7,15);

            //    Console.WriteLine("My birthday is  {0}", dateTime);

            //    //Write today on screen
            //    Console.WriteLine(DateTime.Today);
            //    // Write current time 
            //    Console.WriteLine(DateTime.Now);
            //    Console.WriteLine();

            //    DateTime tomorrow = GetTomorrow();

            //    Console.WriteLine("Tomorrow will be {0}", tomorrow);

            //    Console.WriteLine(DateTime.Today.DayOfWeek);

            //    Console.WriteLine(GetFirstDayOfYear(1977));

            //    int days = DateTime.DaysInMonth(2000, 2);
            //    Console.WriteLine("Days in Feb 2000: {0}",  days);
            //    days = DateTime.DaysInMonth(2001, 2);
            //    Console.WriteLine("Days in Feb 2001: {0}", days);
            //    days = DateTime.DaysInMonth(2004, 2);
            //    Console.WriteLine("Days in Feb 2004: {0}", days);

            //    DateTime now = DateTime.Now;
            //    Console.WriteLine("Minute: {0}",now.Minute);

            //    DateTime hour = DateTime.Now;
            //    DateTime min = DateTime.Now;
            //    DateTime sec = DateTime.Now;

            //    Console.WriteLine("The time is {0} o'clock {1} minuted and {2} seconds", hour.Hour,min.Minute,sec.Second);

            //    Console.WriteLine("Write a date in this format yyyy-mm-dd");
            //    string input = Console.ReadLine();
            //    if(DateTime.TryParse(input, out dateTime))
            //    {
            //        Console.WriteLine(dateTime);
            //        TimeSpan daysPassed = now.Subtract(dateTime);

            //        Console.WriteLine("Days passed since: {0}" , daysPassed.Days);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong input");
            //    }
            //    Console.WriteLine("Input your birthday in this format yyyy-mm-dd");
            //    string birthDay = Console.ReadLine();
            //    if (DateTime.TryParse(birthDay, out dateTime))
            //    {
            //        Console.WriteLine(dateTime);
            //        TimeSpan daysPassed = now.Subtract(dateTime);

            //        Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong input");
            //    }


            //    Console.ReadLine();
            //}
            //static DateTime GetTomorrow()
            //{
            //    return DateTime.Today.AddDays(1);
            //}
            //static DateTime GetFirstDayOfYear(int year)
            //{
            //    return new DateTime(year, 1, 1);
            //}

            int? num1 = null;
            int? num2 = 1337;
            int num5;

            double? num3 = new Double?();

            double? num4 = 3.14157;

            bool? boolval = new bool?();

            Console.WriteLine("Our nullable numbers are {0},{1},{2},{3}", num1, num2, num3,num4);
            Console.WriteLine("The nullable boolean value is {0}", boolval);

            bool? isMale = null;
            if(isMale == true)
            {
                Console.WriteLine("User is male");
            } 
            else if(isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender selected");
            }
            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if(num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6;
            }

            Console.WriteLine("Value of num8 is {0}", num8);

            num8 = num6 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}",num8);
            num8 = num7 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num8);

            Console.Read();
        }
    }
} 
