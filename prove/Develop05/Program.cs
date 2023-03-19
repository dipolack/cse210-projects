using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//^ Sources
//https://learn.microsoft.com/en-us/dotnet/api/system.text.encoding?view=net-7.0
//https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task?view=net-8.0


namespace Goals
{
    public static class Program
    {
        static int Main(string[] args)
        {

			//Load users' information and sample goals in the members of application data class.
            Initialize.InitializeApplicationData(); 
            try
            {
                //This provides users with a console window interface from which they can create and manipulate their goals. 
                //It allows multiple users which is my attempt to show the esence of object oriented programming. 
                //No user can change/manipulate another user's goals.

				//Exciding requirements ^
                
				return Initialize.RunApplication();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred in the application\n{ex.Message}");
                return 1;
            }
        }
    }
}
