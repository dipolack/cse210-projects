//Subclass for simple goals that can be marked complete

public class SimpleGoal : Goal

{
    //Constructor
    public SimpleGoal(string name, int points) : base(name, points)
    {

    }

    //Override MarkCompleted method to simply call the parent implementation

    public override int MarkCompleted()

    {
        return base.MarkCompleted();
    }
}
