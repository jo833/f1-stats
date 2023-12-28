namespace f1_statistics;
using System;

class F1_stats
{
    public static void Pitstops()
    {
        double C1 = 50;
        double C2 = 40;
        double C3 = 30;
        double C4 = 20;
        double C5 = 10;

        Console.WriteLine("Please Insert Number of Laps:");
        double numberOfLaps = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please Insert Weather in Celsius:");
        int weather = Convert.ToInt32(Console.ReadLine());
        double weatherDegragation;
        if (weather > 28)
        {
            weatherDegragation = 1.2; //tyes wear down quicker in warmer temperatures
        }
        else
        {
            weatherDegragation = 1.0; //ideal weather
        }

        double C1PitStop = (numberOfLaps / C1 * weatherDegragation) - 1;
        double C2PitStop = (numberOfLaps / C2 * weatherDegragation) - 1;
        double C3PitStop = (numberOfLaps / C3 * weatherDegragation) - 1;
        double C4PitStop = (numberOfLaps / C4 * weatherDegragation) - 1;
        double C5PitStop = (numberOfLaps / C5 * weatherDegragation) - 1;
        double hardTyres = (C1PitStop + C2PitStop + C3PitStop) / 3;
        double mediumTyres = (C2PitStop + C3PitStop + C4PitStop) / 3;
        double softTyres = (C3PitStop + C4PitStop + C5PitStop) / 3;

        Console.WriteLine($"Number of Pitstops Using C1: {C1PitStop}");
        Console.WriteLine($"Number of Pitstops Using C2: {C2PitStop}");
        Console.WriteLine($"Number of Pitstops Using C3: {C3PitStop}");
        Console.WriteLine($"Number of Pitstops Using C4: {C4PitStop}");
        Console.WriteLine($"Number of Pitstops Using C5: {C5PitStop}");

        Console.WriteLine($"Number of Pitstops Using Hard Tyres: {hardTyres}");
        Console.WriteLine($"Number of Pitstops Using Medium Tyres: {mediumTyres}");
        Console.WriteLine($"Number of Pitstops Using Soft Tyres: {softTyres}");
    }

    public static void StartScreenMessage()
    {
        Console.WriteLine("Welcome to F1 Statistics");
        Console.WriteLine("Please Select:");
        Console.WriteLine("1. Pitstops Needed");
        Console.WriteLine("2. Constructor Cups Likeliness");
        Console.WriteLine("3. Exit");
    }
    public static void StartScreen()
    {
        StartScreenMessage();
        int result = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            if (result == 1)
            {
                Pitstops();
                StartScreen();
                break;
            }
            else if (result == 2)
            {
                //TODO
                break;
            }
            else if (result == 3)
            {
                Console.WriteLine("Goodbye");
                break;
            }
            else
            {
                Console.WriteLine("Error: Try Again");
                StartScreenMessage();
                result = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public static void Main()
    {
        StartScreen();
    }
}

