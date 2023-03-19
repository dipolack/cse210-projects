public class Goal
{
    // Private attributes

    public string Name { get;set; }

    public int RecordGoal;

    public int Serialize;

    public static Goal Deserialize;

    public int Points{get;set;}

    public bool Completed { get; set; }
    public string Type { get; set; }
    public string getName() { return Name; }


    // Constructor
    public Goal(string Name, int Points)
    {
        this.Name = Name;
        this.Points = Points;
        this.Completed = false;
    }

// Mark this goal as completed and return the points earned
    public virtual int MarkCompleted()
    {
        Completed = true;
        return Points;
    }

// Get a string description of this goal
    public virtual string GetDescription()
    {
        return $"{Name} ({Points} points) [{(Completed ? "X" : " ")}]";
    }

}