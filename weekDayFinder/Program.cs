namespace weekDayFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            bool Sunday = false;
            int dayIdx = 1; int monthIdx = 1; int yearIdx = 1; int weekDay = 1;
            while (monthIdx <= 12)
            {
                if (month == 1 | month == 3 | month == 5 | month == 7 | month == 8 | month == 10 | month == 12)
                {
                    while (dayIdx <= 31)
                    {
                        if (weekDay == 7)
                            weekDay = 0;
                        dayIdx++;
                        weekDay++;
                        if (monthIdx == month & dayIdx == day)
                            goto Ibrahim;
                    }
                    dayIdx = 0;
                }
                if (month == 4 | month == 6 | month == 7 | month == 8 | month == 9 | month == 11)
                {
                    while (dayIdx <= 30)
                    {
                        if (weekDay == 7)
                            weekDay = 0;
                        dayIdx++;
                        weekDay++;
                        if (monthIdx == month & dayIdx == day)
                            goto Ibrahim;
                    }
                    dayIdx = 0;
                }
                if (month == 2)
                {
                    if (year % 4 == 0)
                    {
                        while (dayIdx <= 29)
                        {
                            if (weekDay == 7)
                                weekDay = 0;
                            dayIdx++;
                            weekDay++;
                            if (monthIdx == month & dayIdx == day)
                                goto Ibrahim;
                        }
                        dayIdx = 0;
                    }
                    else
                    {
                        while (dayIdx <= 28)
                        {
                            if (weekDay == 7)
                                weekDay = 0;
                            dayIdx++;
                            weekDay++;
                            if (monthIdx == month & dayIdx == day)
                                goto Ibrahim;
                        }
                        dayIdx = 0;
                    }
                }
                monthIdx++;
            }
        Ibrahim:
            Console.WriteLine(weekDay); ;
        }
    }
}
