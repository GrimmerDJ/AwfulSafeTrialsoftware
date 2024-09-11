using System;

class MoveEstimator
//Figured out how to name classes, I changed something in csproj
{
    static void Main()
    {
        // Floats just because they might change one day.
        const double BaseRate = 200.0;
        const double HourlyRate = 150.0;
        const double PerMileRate = 2.0;

        Console.Write("Enter the estimated number of hours for the job: ");
        double hours = double.Parse(Console.ReadLine());

        Console.Write("Enter the estimated number of miles for the move: ");
        double miles = double.Parse(Console.ReadLine());

        double totalFee = BaseRate + (HourlyRate * hours) + (PerMileRate * miles);

        // Learned the 2 decimal place formatting from ChatGPT
        Console.WriteLine($"\nThe total moving fee is: ${totalFee:F2}");
    }
}