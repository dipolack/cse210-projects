public abstract class Activity

{
    public string Name { get; set; } //refers to activities
    public string Description { get; set; }
    public int Duration { get; set; }
    public abstract void RunActivity();
}