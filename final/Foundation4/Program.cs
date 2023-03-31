using System;
using System.Collections.Generic;

class Program

{ 
    static void Main(string[] args)

    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>()

        {
            
            new Running(new DateTime(2022, 3, 1), 30, 4.2),
            new StationaryBicycle(new DateTime(2022, 3, 2), 45, 30),
            new Swimming(new DateTime(2022, 3, 3), 60, 20),
            new Running(new DateTime(2022, 3, 4), 45, 6.1),
            new StationaryBicycle(new DateTime(2022, 3, 5), 60, 25),
            new Swimming(new DateTime(2022, 3, 6), 90, 40),
            new Running(new DateTime(2022, 3, 7), 30, 3.5),
            new StationaryBicycle(new DateTime(2022, 3, 8), 60, 35),
            new Swimming(new DateTime(2022, 3, 9), 45, 30)
        
        };

         // Print out a summary of each activity
        foreach (Activity activity in activities)
        {
            
        Console.WriteLine(activity.GetSummary());
        
        }

        Console.ReadLine();
    }
}
