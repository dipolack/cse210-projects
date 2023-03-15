//adding futuregoal class to record additional goals for the future
public class FutureGoal: Goal

{
    //Private attributes
    private int pointsPerCompletion;
    private int targetCount;
    private int completedCount;

    //Constructor
    public FutureGoal (string name, int pointsPerCompletion, int targetCount) : base(name, 0)

    {
        this.pointsPerCompletion = pointsPerCompletion;

        this.targetCount = targetCount;

        this.completedCount = 0;
    }

    //Hide the inherited RecordGoal method with a new implementation
    public override int MarkCompleted()

    {

        int pointsEarned = base.MarkCompleted();

        completedCount++;

        if (completedCount == targetCount)

        {
            pointsEarned += pointsPerCompletion * targetCount;
        }

        else

        {
            pointsEarned += pointsPerCompletion;
        }

        return pointsEarned;

    }

    //Override GetDescription to show the total points earned so far

 public override string GetDescription()

    {

        return $"{name} ({pointsPerCompletion} points per completion, {base.GetDescription()}: Completed {completedCount}/{targetCount} times)";

    }

}