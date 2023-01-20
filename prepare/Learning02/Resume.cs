using System;

public class Resume
{
    public string _name;

    // Initialing new list
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop custom data "Job"
        foreach (Job job in _jobs)
        {
            // calling display for each
            job.Display();
        }
    }
}