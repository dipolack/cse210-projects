//Subclass for eternal goals that are never complete but each recording earns points

public class EternalGoal : Goal

{

    //Private attributes
    private int pointsPerRecording;

    //Constructor
    public EternalGoal(string name, int pointsPerRecording) : base(name, 0)

    {
        this.pointsPerRecording = pointsPerRecording;
    }

    