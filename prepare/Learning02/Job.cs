
//must put namespace
using System;

//declare public class
public class Job
{
    //create member variables with _ & camelCase
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

//output public display method
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
