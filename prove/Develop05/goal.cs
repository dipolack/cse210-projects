public class Goal

{
    // Private attributes

    public string name;

    public string getName;

    public int RecordGoal;

    public int Serialize;

    public static Goal Deserialize;

    public int points;

    public bool completed;


    // Constructor
    public Goal(string name, int points)

    {
        this.name = name;

        this.points = points;

        this.completed = false;
    }

// Mark this goal as completed and return the points earned
    public virtual int MarkCompleted()

    {
        completed = true;

        return points;
    }

// Get a string description of this goal
    public virtual string GetDescription()

    {
        return $"{name} ({points} points) [{(completed ? "X" : " ")}]";
    }

}