// -It will show starting message
// -it will pause for a few seconds
// -Activity will start
// -Ending message will be given

public class BreathingActivity : Activity
{
    public override void RunActivity()
    {
        Console.WriteLine($"Starting {Name} which will last for {Duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        System.Threading.Thread.Sleep(3000);

        // Start the activity
        // Show the ending message

    }
}