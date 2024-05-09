//must put namespace
using System;

//declare public class
public class Resume
{
    //create member variables with _
    public string _name;

    //create member varibale and intializes list to list of jobs at the sametime
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        //display persons name
        Console.WriteLine($"Name: {_name}");

        //display persons job
        Console.WriteLine("Jobs:");


        //for each loop to cycle through the jobs
        foreach (Job job in _jobs)
        {
            //Calls the display method on each job
            job.Display();
        }
    }
}
