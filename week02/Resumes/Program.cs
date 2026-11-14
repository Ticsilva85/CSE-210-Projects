using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        // Create the first job
        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create the second job
        Job job2 = new Job();

        job2._company = "Google";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2023;
        job2._endYear = 2025;

        // Create the resume
        Resume myResume = new Resume();

        myResume._name = "Tiago Cavalcante";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

        Console.WriteLine("");
    }
}