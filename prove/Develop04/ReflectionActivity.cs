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

    public override void _RunActivity()
    {
        Console.WriteLine($"Starting {Name} for {Duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        // Pause for a few seconds -->
        System.Threading.Thread.Sleep(3000);

        Random random = new Random();
        int promptIndex = random.Next(0, Prompts.Count - 1);
        Console.WriteLine(Prompts[promptIndex]);

        for (int i = 0; i < Questions.Count; i++)
        {
            Console.WriteLine(Questions[i]);
            System.Threading.Thread.Sleep(Duration * 1000);

            // Show a spinner while the program is paused

            Console.CursorLeft = 0;
            Console.Write("|");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("//");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("-");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("\\");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("//");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("-");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("\\");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("|");
            System.Threading.Thread.Sleep(1000);
        }

        // Show the ending message
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Console.WriteLine("Thank you for participating.");
    }
}