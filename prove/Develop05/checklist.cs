public class ChecklistGoal : Goal

{
    //Private attributes
    private int pointsPerCompletion;
    private int targetCount;
    private int completedCount;
    public int GetPointsPerCompletion() { return pointsPerCompletion; }
    public int GetTargetCount() { return targetCount; }
    //Constructor
    public ChecklistGoal(string name, int pointsPerCompletion, int targetCount) : base(name, 0)

    {
        this.pointsPerCompletion = pointsPerCompletion;

        this.targetCount = targetCount;

        this.completedCount = 0;

        this.Type = "Checklist goal";
    }

    // Mark this goal as completed and return the points earned
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

    // Override GetDescription to show the completion status
    public override string GetDescription()

    {

        return $"{Name} ({pointsPerCompletion} points per completion, {base.GetDescription()}: Completed {completedCount}/{targetCount} times)";

    }
    public int MaximumPossiblePoints()
    {
        return pointsPerCompletion * targetCount;
    }

}