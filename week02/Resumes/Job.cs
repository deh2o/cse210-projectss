// let us create a class to represent a job experience in a resume
public class Job
{
    //Let us create member variables in the class
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    // lets add a method to the Job class to display the Job details
    public void DisplayJobDetails()
    {

        Console.WriteLine($"{_jobTitle}, ({_company}) {_startYear} - {_endYear}");
    }
}
