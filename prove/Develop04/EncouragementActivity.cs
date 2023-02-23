public class EncouragementActivity : Activity
{
    public override void RunActivity()
    {
        Console.WriteLine($"Starting {Name} ");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Are you ready to hear some truths about yourself?");

        System.Threading.Thread.Sleep(3000);

        Console.WriteLine("You are a child of god which means you are of celestial lineage!");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("You have overcome things you thought you couldn't!");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("You are strong!");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("You are somebody's favorite person!");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("You inspire others in your own unique way");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("Keep spreading your light among others!");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("You are doing great and I'm proud of you!");
        System.Threading.Thread.Sleep(Duration * 1000);

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Console.WriteLine("Thank you for participating.");
    }
}
