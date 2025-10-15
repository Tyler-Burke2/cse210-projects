using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();

        job1._company = "BYU-Idaho";
        job1._jobTitle = "Ropes Course Facilitator";
        job1._startYear = "2024";
        job1._endYear = "2025";

        job1.DisplayJobDetails();

        Job job2 = new Job();

        job2._company = "12 apostle dentistry";
        job2._jobTitle = "Dentist";
        job2._startYear = "1986";
        job2._endYear = "2005";

        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Tyler Burke";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}