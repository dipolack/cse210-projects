//Subclass for simple goals that can be marked complete

public class SimpleGoal : Goal

{
    //Constructor
    public int awardPoints;
    public SimpleGoal(string name, int points, int awardPoints) : base(name, points)
    {
        this.Name = Name;
        this.Points = Points;
        this.Type = "Simple goal";
        this.Completed = false;
        this.awardPoints = awardPoints;
    }

    //Override MarkCompleted method to simply call the parent implementation

    public override int MarkCompleted()
    {
        Points = awardPoints;
        return base.MarkCompleted();
    }
}
