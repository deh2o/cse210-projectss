using System;

class Program
{
    static void Main(string[] args)
    {
        //lets create an instance of the Job class
        Job job1 = new Job();

        //Let us assign values to the member variables of the job1 instance
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2020";
        job1._endYear = "2023";

        //Lets create another instance of the Job class
        Job job2 = new Job();

        //Let us assign values to the member variables of the job2 instance
        job2._company = "Apple";
        job2._jobTitle = "Product Manager";
        job2._startYear = "2018";
        job2._endYear = "2022";

        // //Let us print the job experience to the console
        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        //Lets create an instance of the Resume class
        Resume resume = new Resume();

        //Let us assign a value to the name member variable of the resume instance
        resume._name = "Idam Agha";

        //Lets add the jobs we created to the resume
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        //Lets add a call to display the resume details
        resume.DisplayResume();

    }
}
