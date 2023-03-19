using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goals
{
    internal static class Initialize
   
    {
        internal static void InitializeApplicationData()
        {
            LoadUsers();
            LoadSystemGoals();
        }
        
        private static void LoadUsers()
        
        {
            if(!File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Users.txt")) File.Create($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Users.txt").Dispose(); //Check whether the file to save user data exists. If it doesn't create it.
            
            else
            
            {
                //Since the file exists, read the data from the file and load it to the users class.
                string applicationUsersData = File.ReadAllText($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Users.txt");//Reads the data and loads them into a sring "applicationUsersData"
                string[] usersData = applicationUsersData.Split(new[] {"\n"},StringSplitOptions.RemoveEmptyEntries);//Splits the string into an array of strings. Each element in the array of strings represents data of a user.
                
                if (usersData.Length == 0) return;
                foreach(string userData in usersData)
                
                {
                    string[] userInfo = userData.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries); //From each element in the array of strings, split it to get user data. Load it into the list of users in ApplicationData class.
                    if(userInfo.Length <= 1)continue;
                    User user = new User(userInfo[0], userInfo[1]);
                    if(userInfo.Length > 2)
                    {
                        for(int i = 2;i <userInfo.Length;i++)
                        {
                            //This for loop loads the goals of the user whose data is being loaded.
                            string[] goalData = userInfo[i].Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                            if (goalData[1] == "Simple goal")
                            {
                                user.Goals.Add(new SimpleGoal(goalData[0], Convert.ToInt32(goalData[2]), Convert.ToInt32(goalData[3])));
                            }
                            else if (goalData[1] == "Eternal goal")
                            {
                                user.Goals.Add(new EternalGoal(goalData[0], Convert.ToInt32(goalData[2])));
                            }
                            else if (goalData[1] == "Checklist goal")
                            {
                                user.Goals.Add(new ChecklistGoal(goalData[0], Convert.ToInt32(goalData[2]), Convert.ToInt32(goalData[3])));
                            }
                        }
                    }
                    ApplicationData.Users.Add(user);
                }
            }
        }
        private static void LoadSystemGoals()
        
        {
            #region Load Simple Goal Data
            //This region reads data from a file "SimpleGoals.txt" and loads the data into the List, SystemSimpleGoals, in Application data class
            if (!File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\SimpleGoals.txt")) File.Create($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\SimpleGoals.txt").Dispose();//If the file "SimpleGoals.txt" does not exist, create it.
            string simpleGoalsData = File.ReadAllText($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\SimpleGoals.txt"); //Read data from the text file "SimpleGoals.txt" and save it on the field simpleGoalsData
            string[] simpleGoalsDataArray = simpleGoalsData.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries); //Split the read data into an array of strings. Each element of the array represents a sample of an object of class SimpleGoal
            foreach(string simpleGoalData in simpleGoalsDataArray)
            {
                string[] simpleGoalDataArray = simpleGoalData.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                if (simpleGoalDataArray.Length != 2) continue;
                ApplicationData.SystemSimpleGoals.Add(new SimpleGoal(simpleGoalDataArray[0], 0,Convert.ToInt32(simpleGoalDataArray[1])));
            }
            #endregion
            #region Load Eternal Goal Data
            //This region reads data from a file "EternalGoals.txt" and loads the data into the List, SystemEternalGoals, in Application data class
            if (!File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EternalGoals.txt")) File.Create($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EternalGoals.txt").Dispose();//If the file "EternalGoals.txt" does not exist, create it.
            string eternalGoalsData = File.ReadAllText($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EternalGoals.txt");//Read data from the text file "EternalGoals.txt" and save it on the field eternalGoalsData
            string[] eternalGoalsDataArray = eternalGoalsData.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);//Split the read data into an array of strings. Each element of the array represents a sample of an object of class EternalGoal
            foreach (string eternalGoalData in eternalGoalsDataArray)
            {
                string[] eternalGoalDataArray = eternalGoalData.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                if (eternalGoalDataArray.Length != 2) continue;
                ApplicationData.SystemEternalGoals.Add(new EternalGoal(eternalGoalDataArray[0], Convert.ToInt32(eternalGoalDataArray[1])));
            }
            #endregion
            #region Load Check List Goal Data
            //This region reads data from a file "CheckList.txt" and loads the data into the List, SystemCheckListGoals, in Application data class
            if (!File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\CheckList.txt")) File.Create($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\CheckList.txt").Dispose(); //If the file "CheckList.txt" does not exist, create it.
            string checkListGoalsData = File.ReadAllText($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\CheckList.txt"); //Read data from the text file "CheckList.txt" and save it on the field checkListData
            string[] checkListGoalsDataArray = checkListGoalsData.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);//Split the read data into an array of strings. Each element of the array represents a sample of an object of class CheckList
            foreach (string checkListGoalData in checkListGoalsDataArray)
            {
                string[] checkListGoalDataArray = checkListGoalData.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                if (checkListGoalDataArray.Length != 2) continue;
                ApplicationData.SystemCheckListGoals.Add(new ChecklistGoal(checkListGoalDataArray[0], Convert.ToInt32(checkListGoalDataArray[1]), Convert.ToInt32(checkListGoalDataArray[2])));
            }
            #endregion
        }

        internal static int RunApplication()
        
        {
            //This function provides a console interface from which the current user will login and manage his/her goals.
            //It also provides a field where a new user can create his/her account.
            try
            {
            BeginApplication:;
                if (ApplicationData.currentUser == null)
                
                {
                  
                    if (ApplicationData.Users.Count == 0)
                    
                    {
                        Console.WriteLine("There are no registered users in the system.\nSelect:\n1. Add a new user\n2. Help\n3. Clear window\n4. Exit");
                        string response = Console.ReadLine();
                        if (response == "1" || response == "Add" || response == "Add a new user")
                        {
                            AddUser();
                            goto BeginApplication;
                        }
                        else if (response == "3" || response.ToLower() == "clear")
                        {
                            Console.Clear();
                            goto BeginApplication;
                        }
                        else if (response == "4" || response == "Exit")
                        {
                            return ExitApplication();
                        }
                    }
                    
                    else
                    
                    {
                        Console.WriteLine("Select:\n1. Add a new user\n2. Login\n3. Help\n4. Clear window\n5. Exit");
                        string response = Console.ReadLine();
                       
                        if (response == "1" || response == "Add" || response == "Add a new user")
                        
                        {
                            AddUser();
                            goto BeginApplication;
                        }
                       
                        else if (response == "2" || response == "Login")
                        
                        {
                            Console.WriteLine("Enter username");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Enter user password");
                            string userPassword = Console.ReadLine();
                            foreach (User user in ApplicationData.Users)
                            
                            {
                                
                                if (user.Name == userName)
                                {
                                    if (user.Password == userPassword)
                                    {
                                        ApplicationData.currentUser = user;
                                        goto BeginApplication;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid password!");
                                        goto BeginApplication;
                                    }
                                }
                            }
                            Console.WriteLine($"User \"{userName}\" does not exist");
                            goto BeginApplication;
                        }
                        else if (response == "4" || response.ToLower() == "clear")
                        {
                            Console.Clear();
                            goto BeginApplication;
                        }
                        else if (response == "5" || response.ToLower() == "exit")
                        {
                            return ExitApplication();
                        }
                    }
                }
                else ApplicationData.currentUser.HandleUser();
                ApplicationData.currentUser = null;
                goto BeginApplication;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
        }
       
        private static void AddUser()
        
        {
            //This method prompts for necessary data to create a user.
            //It then creates a user using the data and adds the user to the list of users in application data.
            Console.WriteLine("Enter user name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password");
            string userPassword = Console.ReadLine();
            ApplicationData.Users.Add(new User(userName, userPassword)); //Create a user and add him/her in the list of users in application data.
            Console.WriteLine($"User {userName} added successfully. Press any key to continue");
            Console.ReadKey();
            Console.WriteLine();
        }
        
        private static int ExitApplication()
        
        {
            //This function is called when the user prompts for exit of the application.
            //It ensures that all the application data is saved in text files before exiting.
            ApplicationData.Save();
            Console.WriteLine("Thank you for using the application. Press any key to exit");
            Console.ReadKey();
            return 0;
        }
    }
}