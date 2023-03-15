using System;

using System.Collections.Generic;

//Class for tracking the user's goals and score

public class GoalTracker

{

    //Private attributes
    private List<Goal> goals;

    private int score;

    //Constructor

    public GoalTracker()

    {
        goals = new List<Goal>();

        score = 0;
    }

    //Add a new goal to the list of goals

    public void AddGoal(Goal goal)

    {
        goals.Add(goal);
    }

//Mark a goal as completed

    public class LargeGoal : Goal

    {
        private int progress;

        private int target;

        public LargeGoal(string name, int points, int target) : base(name, points)

        {
            this.target = target;

            this.progress = 0;
        }


        public void AddProgress(int amount)

        {
            this.progress += amount;

            if (this.progress >= this.target)

            {
               this.completed = true;

                this.points += 500;
            }

        }

         public override string GetDescription()

        {
            string status = this.completed ? "Completed" : "Incomplete";

            return $"{this.name}: {status}, Progress: {this.progress}/{this.target}";
        }

    }

    public class NegativeGoal : Goal

    {
        public NegativeGoal(string name, int points) : base(name, points)

        {
            this.points *= -1;
        }

   public override int MarkCompleted()

        {
            this.completed = true;

            return this.points;
        }

        public override string GetDescription()

        {
            return $"{this.name}: {(this.completed ? "Completed" : "Incomplete")}, {this.points} points";
        }

    }

    public class GoalTracker1

    {
        private List<Goal> goals;
        private int score;
        public GoalTracker1()
        {
            this.goals = new List<Goal>();

            this.score = 0;
        }

        public void AddGoal(Goal goal)

        {
            this.goals.Add(goal);
        }

        public void MarkGoalCompleted(string goalName)

        {
            foreach (Goal goal in this.goals)
            {
                if (goal.getName == goalName)

                {
                    this.score += goal.MarkCompleted();

                    return;
                }
            }
        }

         public void RecordGoal(string goalName)

        {
            foreach (Goal goal in this.goals)
            {
                if (goal.getName == goalName)
                {
                    this.score += goal.RecordGoal;

                    return;
                }
            }
        }