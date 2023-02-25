
//Aditional activity for exceding requirements
//This activity will give the user encouraging messages seconds interval
//The purpose of this activity is to remind the user of their worth/strenghts.
public class EncouragementActivity : Activity
{
    public override void _RunActivity()
    {
        Console.WriteLine($"Starting {Name} ");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Are you ready to hear some truths about yourself?");
        Console.WriteLine("Here it goes...");
        System.Threading.Thread.Sleep(3000);

        Console.WriteLine("You are a child of god which means you are of celestial lineage!");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("You have overcome things you thought you couldn't!");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("You are strong!");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("You are somebody's favorite person!");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("You inspire others in your own unique way!");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("Keep spreading your light among others!");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("You are doing great, be proud of yourself!");
        System.Threading.Thread.Sleep(Duration * 1000);

        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} for {Duration} seconds.");
        Console.WriteLine("Thank you for participating.");
        Console.WriteLine("And please, don't forget how awesome you are!");
    }
}
