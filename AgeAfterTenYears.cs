using System;

class AgeAfterTenYears
{
    static void Main()
    {

        //Input data from the User
        Console.WriteLine("Please enter your birth year");
        string BirthYear = Console.ReadLine();

        int year;

        while (int.TryParse(BirthYear, out year) == false)
        {
            Console.WriteLine("Invalid input. Please enter for example 1987 etc.");
            BirthYear = Console.ReadLine();
        }

        Console.WriteLine("Please enter your birth month");
        string BirthMonth = Console.ReadLine();

        int month;

        while (int.TryParse(BirthMonth, out month) == false)
        {
            Console.WriteLine("Invalid input. Please enter for example 1,2,3 etc.");
            BirthMonth = Console.ReadLine();
        }

        Console.WriteLine("Please enter your birth day");
        string BirthDay = Console.ReadLine();

        int day;

        while (int.TryParse(BirthDay, out day) == false)
        {
            Console.WriteLine("Invalid input. Please enter for example 1,2,3 etc.");
            BirthDay = Console.ReadLine();
        }
        //Get the pressent date Year/Month/Day
        DateTime PresentDate = DateTime.Now;
        int PresentYear = PresentDate.Year;
        int PresentMonth = PresentDate.Month;
        int PresentDay = PresentDate.Day;
        //Calculate the present Age.

        Age(year, month, day, PresentYear, PresentMonth, PresentDay);

    }
    private static void Age(int year, int month, int day, int PresentYear, int PresentMonth, int PresentDay)
    {


        //Makes Substraction between the present date Year/Month/Day and...
        //the birth date Year/Month/Day.
        DateTime date1 = new DateTime(PresentYear, PresentMonth, PresentDay, 0, 0, 0);
        DateTime date2 = new DateTime(year, month, day, 0, 0, 0);
        DateTime date3 = new DateTime(PresentYear + 10, PresentMonth, PresentDay, 0, 0, 0);


        System.TimeSpan diff1 = date1.Subtract(date2);
        System.TimeSpan diff2 = date3.Subtract(date2);

        //Gets total days to the present moment.
        double days = diff1.TotalDays;
        double daysTen = diff2.TotalDays;



        //Calculates the number of the leap years till the present moment.
        int leapyears = 0;
        for (int y = year; y <= PresentYear; y++)
        {
            if (DateTime.IsLeapYear(y) == true)
            {
                leapyears++;
            }
        }
        int leapyearsTen = 0;
        for (int z = year; z <= PresentYear + 10; z++)
        {
            if (DateTime.IsLeapYear(z))
            {
                leapyearsTen++;
            }
        }
        //Calculates the number of the leap days.
        int TotalLeapDays = leapyears;
        int TotalLeapDaysTen = leapyearsTen;
        //Calculates the number of the days to the present moment without the leap days.
        int TotalDays = (int)days - leapyears;
        int TotalDaysTen = (int)daysTen - leapyearsTen;
        //Calculates the Age on the base of the days
        int AgeYears = TotalDays / 365;
        int AgeYearsTen = TotalDaysTen / 365;

        //Calculates the left days after the age was calculated.
        double LeftDays = (int)TotalDays % 365;
        double LeftDaysTen = (int)TotalDaysTen % 365;
        //Estimating the precise Age with precision to Months and Days
        int AgeMonths = (int)LeftDays / 31;
        int AgeDays = (int)LeftDays % 31;
        //Estimate the Age after 10 years
        int AgeMonthsTen = (int)LeftDaysTen / 31;
        int AgeDaysTen = (int)LeftDaysTen % 31;
        Console.WriteLine("By this moment you are on {0} year(s), {1} month(s) and {2} day(s)", AgeYears, AgeMonths, AgeDays);
        Console.WriteLine("After 10 years you will be on {0} year(s), {1} month(s) and {2} day(s)", AgeYearsTen, AgeMonthsTen, AgeDaysTen);
    }
}

