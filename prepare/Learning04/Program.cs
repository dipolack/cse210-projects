using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Dorca Polack", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment ma2 = new MathAssignment("Alessandro Torres", "Fractions", "7.3", "8-19");
        Console.WriteLine(ma2.GetSummary());
        Console.WriteLine(ma2.GetHomeworkList());

        WritingAssignments ma3 = new WritingAssignments("Christian Torres", "European History", "The Causes of World War II");
        Console.WriteLine(ma3.GetSummary());
        Console.WriteLine(ma3.GetWritingInformation());
    }
}