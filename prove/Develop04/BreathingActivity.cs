// -It will show starting message
// -it will pause for a few seconds
// -Activity will start
// -Ending message will be given

public class BreathingActivity : Activity
{
    int _cycle = 0;
    public void Spinner(int a)
    {
        int numb = 0;
        do{
            Console.Write('|');
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write('/');
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write('-');
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            numb+=1;
        } while(numb !=a);
    }
    public void TimerDown(int a){
        while ( a >=0)
        {          
            Console.Write("\b \b");
            Console.Write(a);
            System.Threading.Thread.Sleep(1000);
            a--;
        }
    }
    public void TimerUp(){
        int a =0;
        while (a <=4)
        {
            Console.Write("\b \b");
            Console.Write(a);
            System.Threading.Thread.Sleep(1000);
            a++;
        }
    }
    public override void RunActivity()
    {
        Console.WriteLine($"Starting {Name} which will last for {Duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        _cycle = Duration / 10;

        while (_cycle!=0)
        {    
            Console.WriteLine();           
            Console.Write("Breath In... ") ;
            TimerUp();
            Console.Write("\b \b");
            Console.WriteLine();
            Console.WriteLine("and");
            Thread.Sleep(500);
            
            Console.Write("Breath Out... ");
            TimerDown(6);
            Console.Write("\b \b");
            Console.WriteLine();
            
            _cycle--;
        }

        // Show the ending message
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Console.WriteLine("Thank you for participating.");
    }
}
