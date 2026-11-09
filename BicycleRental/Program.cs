using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========== PROBLEM 1 ==========");
        Console.WriteLine("Bicycle rental");
        Console.WriteLine();
        Console.WriteLine("Enter whole hours only.");
        Console.WriteLine("Starting hour: 0 to 23");
        Console.WriteLine("Ending hour:   1 to 24");
        Console.WriteLine();

        int startHour = ReadHour("Starting hour: ", 0, 23);
        int endHour = ReadHour("Ending hour: ", 1, 24);

        while (startHour >= endHour)
        {
            Console.WriteLine("Starting hour must be less than ending hour. Try again.");
            startHour = ReadHour("Starting hour: ", 0, 23);
            endHour = ReadHour("Ending hour: ", 1, 24);
        }

        int hoursAt500 = 0;
        int hoursAt1000 = 0;
        int hoursAt1500 = 0;

        for (int hour = startHour; hour < endHour; hour++)
        {
            int rate = RateForHour(hour);

            if (rate == 500)
                hoursAt500 = hoursAt500 + 1;
            else if (rate == 1000)
                hoursAt1000 = hoursAt1000 + 1;
            else
                hoursAt1500 = hoursAt1500 + 1;
        }

        int pay500 = hoursAt500 * 500;
        int pay1000 = hoursAt1000 * 1000;
        int pay1500 = hoursAt1500 * 1500;
        int total = pay500 + pay1000 + pay1500;

        Console.WriteLine();
        Console.WriteLine("From " + startHour + ":00 to " + endHour + ":00");
        Console.WriteLine("Hours rented: " + (endHour - startHour));
        Console.WriteLine("500 RWF  x " + hoursAt500 + " = " + pay500 + " RWF");
        Console.WriteLine("1000 RWF x " + hoursAt1000 + " = " + pay1000 + " RWF");
        Console.WriteLine("1500 RWF x " + hoursAt1500 + " = " + pay1500 + " RWF");
        Console.WriteLine("Total to pay: " + total + " RWF");
        Console.WriteLine();
        Console.Write("Press Enter to close.");
        Console.ReadLine();
    }

    static int RateForHour(int hour)
    {
        if (hour < 7)
            return 500;
        if (hour < 14)
            return 1000;
        if (hour < 19)
            return 1500;
        if (hour < 21)
            return 1000;

        return 500;
    }

    static int ReadHour(string prompt, int minimum, int maximum)
    {
        while (true)
        {
            Console.Write(prompt);
            string text = Console.ReadLine() ?? "";
            int hour;

            if (!int.TryParse(text, out hour))
            {
                Console.WriteLine("Decimal numbers are not accepted. Enter a whole number.");
                continue;
            }

            if (hour < minimum || hour > maximum)
            {
                Console.WriteLine("Enter a whole number from " + minimum + " to " + maximum + ".");
                continue;
            }

            return hour;
        }
    }
}
