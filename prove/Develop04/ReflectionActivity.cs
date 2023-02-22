// -It will show starting message
// -It will pause for a few secs
// - random prompt will be given
// -questions will be asked
// -spinner will be shown while program is paused

// The class for the reflection activity
public class ReflectionActivity : Activity
{
    public List<string> Prompts { get; set; }

    public List<string> Questions { get; set; }

    public override void RunActivity()
    {
        Console.WriteLine($"Starting {Name} which will last for {Duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        // Pause for a few seconds -->
        System.Threading.Thread.Sleep(3000);

        Random random = new Random();
        int promptIndex = random.Next(0, Prompts.Count - 1);
        Console.WriteLine(Prompts[promptIndex]);

        //continue asking questions
        //ending message
       
    }
}

