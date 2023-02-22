// -It will show starting message
// -it will pause for a few secs
// -random prompt will be given
// -user will be given a few secs to think
// -user will be asked to start listing
// -ending message will be given
public class ListingActivity : Activity
{
    public List<string> Prompts { get; set; }

    public override void RunActivity()
    {

        Console.WriteLine($"Starting {Name} which will last for {Duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Now, prepare to begin...");

        System.Threading.Thread.Sleep(3000);

        Random random = new Random();
        int promptIndex = random.Next(0, Prompts.Count - 1);
        Console.WriteLine(Prompts[promptIndex]);

        //Continue with giving user seconds to think..
        // ask them to start listing
        // ending message
    }
}

