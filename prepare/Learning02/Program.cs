using System;

class Program
{
    static void Main(string[] args)
    {
        //create a new job using Job job1 = new job();
        Job job1 = new Job();
        //create a new variable using dot notation
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Console.WriteLine(job1._jobTitle);
        // Console.WriteLine(job1._company);
        // Console.WriteLine(job1._startYear);
        // Console.WriteLine(job1._endYear);

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        ///display class function
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        //New instance of the Resume class
        Resume myResume = new Resume();
        //method body display persones name
        myResume._name = "Allison Rose";

        //iterate through each Job instance in the list of jobs and display them
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        
    }
}

