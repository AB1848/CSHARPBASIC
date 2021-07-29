using System;

namespace DayWeek
{

    enum DayOfWeek
    {
        sunday, monday, tuesday, wednesday, thursday, friday, saturday
    }

    internal class Demo
    {
        public DayOfWeek Days { get; set; }
        void PrintGreeting()
        {
            if (Days == DayOfWeek.saturday)
            {
                Console.WriteLine("HAPPY SATURDAY");

            }
            else if (Days == DayOfWeek.sunday)
            {
                Console.WriteLine("happy weekend");

            }
            else
            {
                Console.WriteLine("oh gosh its work day");
            }
        }
    }
}