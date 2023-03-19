//Subclass for eternal goals that are never complete but each recording earns points

public class EternalGoal : Goal

{
    //Private attributes
    private int pointsPerRecording;
    public int GetPointsPerRecording()
    { return pointsPerRecording; }

    //Constructor
    public EternalGoal(string Name, int pointsPerRecording) : base(Name, 0)
    {
        this.pointsPerRecording = pointsPerRecording;
        this.Type = "Eternal goal";
    }

//Hide the inherited RecordGoal method with a new implementation
    public new int RecordGoal()
    {
        int pointsEarned = base.MarkCompleted();

        pointsEarned += pointsPerRecording;

        return pointsEarned;
    }
    //Override GetDescription to show the total points earned so far
    public override string GetDescription()
    {
        return $"{Name} ({pointsPerRecording} points per recording, {base.GetDescription()}: {pointsPerRecording * Convert.ToInt32(Completed)})";
    }

}
