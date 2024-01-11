using System;
using System.Collections.Generic;

    public class Resume{

    //Propieties
    public string _name = "";
    //List of Jobs
    public List<Job> _jobs = new List<Job>();

    //Methods
    public void Display(){
        Console.WriteLine($"Name: {_name}");
        
        Console.WriteLine($"Jobs:");
        
        //Display all the jobs in the list _jobs
        foreach (Job elementJob in _jobs)
        {
         //Display all the information inside the element
         elementJob.Display();
            
        }
    }

    }