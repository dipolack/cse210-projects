using System;

public class Job
{
//Referencing start-end-company-andjobtitle
    public int _startYear;
    public int _endYear; 
    public string _company;
    public string _jobTitle;
     
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}