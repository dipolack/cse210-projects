// -It will show starting message
// -it will pause for a few seconds
// -Activity will start
// -Ending message will be given

public class BreathingActivity : Activity
{
    public override void RunActivity()
    {
        // Show the starting message
        Console.WriteLine($"Starting {Name} ");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        // Pause for a few seconds
        System.Threading.Thread.Sleep(3000);

        // Start the activity
        Console.WriteLine("Breathe in...");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.CursorLeft = 0;
            Console.Write("|");
        Console.WriteLine("Breathe out...");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.CursorLeft = 0;
            Console.Write("//");

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Console.WriteLine("Thank you for participating.");
    }
}
