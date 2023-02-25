// -It will show starting message
// -it will pause for a few secs
// -random prompt will be given
// -user will be given a few secs to think
// -user will be asked to start listing
// -ending message will be given
public class ListingActivity : Activity
{
    public List<string> Prompts { get; set; }
    public override void _RunActivity()
    {
        // Show the starting message
        Console.WriteLine($"Starting {Name}, it will last for {Duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        // Pause for a few seconds
        System.Threading.Thread.Sleep(3000);

        // Get a random prompt
        Random random = new Random();
        int promptIndex = random.Next(0, Prompts.Count - 1);
        Console.WriteLine(Prompts[promptIndex]);

        System.Threading.Thread.Sleep(Duration * 1000);

        Console.WriteLine("Start listing...");
        int itemCount = 0;
        while (Duration > 0)
        {
            string input = Console.ReadLine();
            itemCount++;
            Duration--;
        }

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for 10 seconds and listed {itemCount} items.");
        Console.WriteLine("Thank you for participating.");
    }
}