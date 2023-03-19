using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goals

{
    internal static class ApplicationData
    {
        //This class holds all the data partaining the application during run time
        //During initialization, data read from text files is loaded into members of this class
        
        
        //This list holds the users in the application.
        internal static List<User> Users = new List<User>(); 

        //This field holds the current logged in user.
        internal static User currentUser = null;  

        //This field holds the list of sample simple goals
        internal static List<SimpleGoal> SystemSimpleGoals = new List<SimpleGoal>();

        //This field holds the list of sample eternal goals
        internal static List<EternalGoal> SystemEternalGoals = new List<EternalGoal>();

        //This field holds the list of sample checklist goals
        internal static List<ChecklistGoal> SystemCheckListGoals = new List<ChecklistGoal>();
        internal static void Save()
        {
            //This method is called when the application is exiting
            //It saves all the members of this class in text files

            #region Save Users' Data

            //This region saves Users in a file known as users.txt
            //so his region saves the user's goals in the same file

            string usersData = "";
            int iUsers = 0;
            foreach(User user in Users)
            {
                usersData += $"{user.Name}\t{user.Password}";
                foreach (Goal goal in user.Goals)
                {
                    if(goal.Type == "Simple goal")
                    {
                        usersData += $"\t{goal.Name}|{goal.Type}|{goal.Points}|{(goal as SimpleGoal).awardPoints}";
                    }
                    else if(goal.Type == "Eternal goal")
                    {
                        usersData += $"\t{goal.Name}|{goal.Type}|{goal.Points}";
                    }
                    else if(goal.Type == "Checklist goal")
                    {
                        usersData += $"\t{goal.Name}|{goal.Type}|{(goal as ChecklistGoal).Completed}|{(goal as ChecklistGoal).GetTargetCount()}";
                    }
                }
                if(iUsers != Users.Count)
                {
                    usersData += "\n";
                }
                iUsers++;
            }

            if (!File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Users.txt")) File.Create($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Users.txt").Dispose();
            File.WriteAllText($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Users.txt", usersData);
            #endregion
            #region Save Simple Goal Data

            //This region saves the contents of the List "SystemSimpleGoals" in a file known as SimpleGoals.txt
           
            string simpleGoalSaveData = "";
            int isimple = 1;
            foreach(SimpleGoal simpleGoal in SystemSimpleGoals)
            {
                simpleGoalSaveData += $"{simpleGoal.Name}\t{simpleGoal.Points}";
                if (isimple != SystemSimpleGoals.Count) simpleGoalSaveData += "\n";
                isimple++;
            }
            if (!File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\SimpleGoals.txt")) File.Create($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\SimpleGoals.txt").Dispose();
            File.WriteAllText($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\SimpleGoals.txt", simpleGoalSaveData);
            #endregion
            #region Save Eternal Goal Data
            //This region saves the contents of the List "SystemEternalGoals" in a file known as EternalGoals.txt
            

            string eternalGoalSaveData = "";
            int iEternal = 1;
            foreach (EternalGoal eternalGoal in SystemEternalGoals)
            {
                eternalGoalSaveData += $"{eternalGoal.Name}\t{eternalGoal.GetPointsPerRecording()}";
                if (iEternal != SystemEternalGoals.Count) eternalGoalSaveData += "\n";
                iEternal++;
            }
            if (!File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EternalGoals.txt")) File.Create($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EternalGoals.txt").Dispose();
            File.WriteAllText($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\EternalGoals.txt", eternalGoalSaveData);
            #endregion
            #region Save CheckList Goal Data
            //This region saves the contents of the List "SystemCheckListGoals" in a file known as CheckList.txt
            
            
            string checkListGoalSaveData = "";
            int iCheckList = 1;
            foreach (ChecklistGoal checkListGoal in SystemCheckListGoals)
            {
                checkListGoalSaveData += $"{checkListGoal.Name}\t{checkListGoal.GetPointsPerCompletion()}\t{checkListGoal.GetTargetCount()}";
                if (iCheckList != SystemCheckListGoals.Count) checkListGoalSaveData += "\n";
                iCheckList++;
            }
            if (!File.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\CheckList.txt")) File.Create($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\CheckList.txt").Dispose();
            File.WriteAllText($@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\CheckList.txt", checkListGoalSaveData);
            #endregion
        }
    }
}
