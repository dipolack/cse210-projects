using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goals
{
    internal class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Goal> Goals { get; set; }
        internal User(string Name,string Password)
        {
            this.Name = Name;
            this.Password = Password;
            Goals = new List<Goal>();
        }
        internal void HandleUser()
        {
            
            Console.Clear();
            Console.WriteLine($"Welcome {ApplicationData.currentUser.Name}");
        begin:;
            
            Console.WriteLine("Select:\n1. View and manage your goals\n2. Add a new goal\n3. Clear window\n4. Log out");
            string response = Console.ReadLine();
            if (response == null) return;
            else if(response == "1" || response.ToLower() == "view" )
            
            {
                if(Goals.Count == 0)
                
                {
                    Console.WriteLine("You have no goals. Select option 2 to add new goals");
                   
                    goto begin;
                }
                Console.WriteLine("Below are your goals.\nSelect goal to view and manage");
                int i = 0;
                foreach(Goal goal in Goals)
                {
                    Console.WriteLine($"{++i}. NAME=>{goal.Name}\tTYPE=>{goal.Type}\tPOINTS=>{goal.Points}\tSTATUS=>{(goal.Completed? "Complete":"Incomplete")}");
                }
                Console.WriteLine("{0} Back", ++i);
                string goalSelection = Console.ReadLine();
                
                if(goalSelection == null) return;
                int selectedGoalIndex;
                
                if (goalSelection == i.ToString()) goto begin;
                
                else if (!int.TryParse(goalSelection, out selectedGoalIndex))
                {
                    Console.WriteLine("Invalid selection");
                    goto begin;
                }
                
                else if (selectedGoalIndex <= 0 || selectedGoalIndex >= i)
                {
                    Console.WriteLine("Invalid selection");
                    goto begin;
                }
                selectedGoalIndex--;
                string goalType = Goals[selectedGoalIndex].Type;
                
                if (goalType == "Simple goal") ManageSimpleGoal(Goals[selectedGoalIndex]);
                
                else if (goalType == "Eternal goal") ManageEternalGoal(Goals[selectedGoalIndex]);
                
                else if (goalType == "Checklist goal") ManageCheckListGoal(Goals[selectedGoalIndex]);
                
                goto begin;
            }
            
            else if (response == "2" || response.ToLower() == "new")
            
            {
            addNewGoal:;
                Console.WriteLine("Select goal type\n1. Simple goal.\n2. Eternal goal.\n3. Check list goal.\n4. Clear window.\n5. Previous menu.");
                string goalResponse = Console.ReadLine();
                #region Add Simple Goal
                
                if (goalResponse == "1")
                
                {
                
                sampleGoalSelection:;
                    Console.WriteLine($"Select a goal from the sample simple goals below. Select option {ApplicationData.SystemSimpleGoals.Count + 1} to add a new sample goal");
                    int i = 0;
                    foreach(SimpleGoal systemSimpleGoal in ApplicationData.SystemSimpleGoals)
                
                    {
                        Console.WriteLine($"{++i}. GOAL=> {systemSimpleGoal.Name}.\t\tREWARD=> {systemSimpleGoal.Points} points");
                    }
                
                    Console.WriteLine($"{++i}. Add a new sample goal");
                    string sampleGoalSelection = Console.ReadLine();
                    int selectedGoalIndex;
                
                    if (sampleGoalSelection == i.ToString()) { addNewSimpleSampleGoal(); goto sampleGoalSelection; }
                
                    else if(!int.TryParse(sampleGoalSelection,out selectedGoalIndex))
                
                    {
                        Console.WriteLine("Invalid selection");
                        goto sampleGoalSelection;
                    }
                    
                    else if(selectedGoalIndex <= 0 || selectedGoalIndex >= i)
                    
                    {
                        Console.WriteLine("Invalid selection");
                        goto sampleGoalSelection;
                    }

                    selectedGoalIndex--;
                    SimpleGoal simpleGoal = new SimpleGoal(ApplicationData.SystemSimpleGoals[selectedGoalIndex].Name, 0, ApplicationData.SystemSimpleGoals[selectedGoalIndex].awardPoints);
                    Goals.Add(simpleGoal);
                    Console.WriteLine("Goal added successfully");
                    goto begin;

                }

                #endregion
                #region Add Eternal Goal

                else if (goalResponse == "2")

                {

                sampleGoalSelection:;
                    Console.WriteLine($"Select a goal from the sample eternal goals below. Select option {ApplicationData.SystemEternalGoals.Count + 1} to add a new sample goal");
                    int i = 0;
                    foreach (EternalGoal systemEternalGoal in ApplicationData.SystemEternalGoals)
                    {
                        Console.WriteLine($"{++i}. GOAL=> {systemEternalGoal.Name}.\t\tREWARD=> {systemEternalGoal.Points} points");
                    }
                    Console.WriteLine($"{++i}. Add a new sample goal");
                    string sampleGoalSelection = Console.ReadLine();
                    int selectedGoalIndex;
                    
                    if (sampleGoalSelection == i.ToString()) { addNewEternalSampleGoal(); goto sampleGoalSelection; }
                    
                    else if (!int.TryParse(sampleGoalSelection, out selectedGoalIndex))
                    
                    {
                        Console.WriteLine("Invalid selection");
                        goto sampleGoalSelection;
                    }
                    
                    else if (selectedGoalIndex <= 0 || selectedGoalIndex >= i)
                    
                    {
                        Console.WriteLine("Invalid selection");
                        goto sampleGoalSelection;
                    }
                    
                    selectedGoalIndex--;
                    EternalGoal eternalGoal = new EternalGoal(ApplicationData.SystemEternalGoals[selectedGoalIndex].Name, 0);
                    Goals.Add(eternalGoal);
                    Console.WriteLine("Goal added successfully");
                    
                    goto begin;
                }

                #endregion
                #region Add Check List Goal

                else if (goalResponse == "3")

                {

                sampleGoalSelection:;
                    Console.WriteLine($"Select a goal from the sample checklist goals below. Select option {ApplicationData.SystemCheckListGoals.Count + 1} to add a new sample goal");
                    int i = 0;
                    foreach (ChecklistGoal systemChecklistGoal in ApplicationData.SystemCheckListGoals)
                    {
                        Console.WriteLine($"{++i}. GOAL=> {systemChecklistGoal.Name}.\t\tREWARD=> {systemChecklistGoal.MaximumPossiblePoints()} points");
                    }
                    Console.WriteLine($"{++i}. Add a new sample goal");
                    string sampleGoalSelection = Console.ReadLine();
                    int selectedGoalIndex;
                    if (sampleGoalSelection == i.ToString()) { addNewCheckListSampleGoal(); goto sampleGoalSelection; }
                    else if (!int.TryParse(sampleGoalSelection, out selectedGoalIndex))
                    {
                        Console.WriteLine("Invalid selection");
                        goto sampleGoalSelection;
                    }
                    else if (selectedGoalIndex <= 0 || selectedGoalIndex >= i)
                    {
                        Console.WriteLine("Invalid selection");
                        goto sampleGoalSelection;
                    }
                    selectedGoalIndex--;
                    EternalGoal checkListGoal = new EternalGoal(ApplicationData.SystemCheckListGoals[selectedGoalIndex].Name, 0);
                    Goals.Add(checkListGoal);
                    Console.WriteLine("Goal added successfully");
                    goto begin;
                }
                #endregion
                
                else if (goalResponse == "4")

                {

                    Console.Clear();
                    goto addNewGoal;
                }
                
                else if(goalResponse == "5")
                
                {
                   
                    goto begin;
                }

                else
                {
                    Console.WriteLine("Invalid selection");
                    goto addNewGoal;
                }
            }
            else if (response == "3" || response.ToLower() == "clear")
            {
                Console.Clear();
                goto begin;
            }
            else if(response == "4" || response.ToLower() == "log out")
            {
                Console.WriteLine("Log out successfull");
                return;
            }
            else
            {
                Console.WriteLine("Invalid response");
                goto begin;
            }
        }
        private void ManageSimpleGoal(Goal goal)
        {
            Console.WriteLine("Manage Goal");
            Console.WriteLine($"NAME => {goal.Name}\nTYPE => {goal.Type}\nPoints => {goal.Points}");
            Console.WriteLine("Select:\n1. Record an event\n2. Back");
            string Selection = Console.ReadLine();
            if(Selection == "1")
            {
                goal.Points = (goal as SimpleGoal).MarkCompleted();
                Console.WriteLine("Event recorded successfully");
            }
        }
        private void ManageEternalGoal(Goal goal)
        {
            Console.WriteLine("Manage Goal");
            Console.WriteLine($"NAME => {goal.Name}\nTYPE => {goal.Type}\nPoints => {goal.Points}");
            Console.WriteLine("Select:\n1. Record an event\n2. Back");
            string Selection = Console.ReadLine(); if (Selection == "1")
            {
                goal.Points = (goal as EternalGoal).RecordGoal();
                Console.WriteLine("Event recorded successfully");
            }
        }
        private void ManageCheckListGoal(Goal goal)
        {
            Console.WriteLine("Manage Goal");
            Console.WriteLine($"NAME => {goal.Name}\nTYPE => {goal.Type}\nPoints => {goal.Points}\nCompleted {(goal as ChecklistGoal).Completed} out of {(goal as ChecklistGoal).GetTargetCount()}");
            Console.WriteLine("Select:\n1. Record an event\n2. Back");
            string Selection = Console.ReadLine(); if (Selection == "1")
            
            {
               goal.Points = (goal as ChecklistGoal).MarkCompleted();
                Console.WriteLine("Event recorded successfully");
            }
        }
        private void addNewSimpleSampleGoal()
        {
            int maxPoints = 0;
            Console.WriteLine("Enter the name of your sample goal");
            string goalName = Console.ReadLine();
        pointsEntry:;
            Console.WriteLine("Enter the maximum points for your goal");
            string maxPointsEntry = Console.ReadLine();
            
            if (maxPointsEntry == null) goto pointsEntry;
           
            if (!int.TryParse(maxPointsEntry, out maxPoints))
            
            {
                Console.WriteLine("Invalid points entered");
                goto pointsEntry;
            }

        confirmation:;

            Console.WriteLine("Are you sure you want to add the new goal to the system?\n1. Yes\n2. No");
            string confirmEntry = Console.ReadLine();
            if (confirmEntry == null || (confirmEntry != "1" && confirmEntry != "2"))
            
            {
                Console.WriteLine("Invalid selection");
                goto confirmation;
            }
            
            if (confirmEntry == "1")
            
            {
                ApplicationData.SystemSimpleGoals.Add(new SimpleGoal(goalName, 0,maxPoints));
                Console.WriteLine("Sample goal added to system successfully");
            }
        }
        private void addNewEternalSampleGoal()
        {
            int pointsPerRecording = 0;
            Console.WriteLine("Enter the name of your sample goal");
            string goalName = Console.ReadLine();

        pointsEntry:;

            Console.WriteLine("Enter points per recording of your goal");
            string pointsPerRecordingEntry = Console.ReadLine();
            
            
            if (pointsPerRecordingEntry == null) goto pointsEntry;
            
            if (!int.TryParse(pointsPerRecordingEntry, out pointsPerRecording))
            
            {
                Console.WriteLine("Invalid points entered");
                goto pointsEntry;
            
            }
        confirmation:;
         
            Console.WriteLine("Are you sure you want to add the new goal to the system?\n1. Yes\n2. No");
            string confirmEntry = Console.ReadLine();
         
            if (confirmEntry == null || (confirmEntry != "1" && confirmEntry != "2"))
          
            {
          
                Console.WriteLine("Invalid selection");
                goto confirmation;
          
            }
          
            if (confirmEntry == "1")
          
            {
          
                ApplicationData.SystemEternalGoals.Add(new EternalGoal(goalName, pointsPerRecording));
          
                Console.WriteLine("Sample goal added to system successfully");
          
            }
        }
        private void addNewCheckListSampleGoal()
        {
            int pointsPerCompletion = 0,targetCount = 0;
            Console.WriteLine("Enter the name of your sample goal");
            string goalName = Console.ReadLine(); 
            
        completionPointsEntry:;

            Console.WriteLine("Enter points per completion of your goal");
            string pointsPerCompletionEntry = Console.ReadLine();
            
            if (pointsPerCompletionEntry == null) goto completionPointsEntry;
            
            if (!int.TryParse(pointsPerCompletionEntry, out pointsPerCompletion))
            
            {
                Console.WriteLine("Invalid points entered");
                goto completionPointsEntry;
            }

        targetCountEntry:;

            Console.WriteLine("Enter the number of times you want to achieve your goal");
            string targetCountEntry = Console.ReadLine();
            
            if (targetCountEntry == null) goto targetCountEntry;
            
            if (!int.TryParse(targetCountEntry, out targetCount))
            
            {
                Console.WriteLine("Invalid entry");
                goto targetCountEntry;
            }

        confirmation:;
            Console.WriteLine("Are you sure you want to add the new goal to the system?\n1. Yes\n2. No");
            string confirmEntry = Console.ReadLine();
            
            if (confirmEntry == null || (confirmEntry != "1" && confirmEntry != "2"))
            
            {
                Console.WriteLine("Invalid selection");
                goto confirmation;
            }
            
            if (confirmEntry == "1")
            
            {
                ApplicationData.SystemCheckListGoals.Add(new ChecklistGoal(goalName,pointsPerCompletion, targetCount));
                Console.WriteLine("Sample goal added to system successfully");
            }
        }
    }
}
