using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        
        // job 1 details
        Job job1 = new Job();
        job1._jobTitle = "Junior Developer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // job 2 details 
        Job job2 = new Job();
        job2._jobTitle = "Senior Software Developer";
        job2._company = "Stark Industries";
        job2._startYear = 2022;
        job2._endYear = 2024;

        // name of the class resume
        Resume myResume = new Resume();
        myResume._name = "Ian Kazembe";
        
        //Add to the empty list the jobs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        //Resume information
        myResume.Display();

    }
}