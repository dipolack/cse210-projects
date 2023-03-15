//Subclass for checklist goals that must be completed a certain number of times

public class ChecklistGoal : Goal

{
    //Private attributes
    private int pointsPerCompletion;
    private int targetCount;
    private int completedCount;

    //Constructor
    public ChecklistGoal(string name, int pointsPerCompletion, int targetCount) : base(name, 0)

    {
        this.pointsPerCompletion = pointsPerCompletion;

        this.targetCount = targetCount;

        this.completedCount = 0;
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
