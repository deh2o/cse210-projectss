//Lets create a new Resume class to represent a resume
public class Resume
{
    //Lets create a member variable to hold the name of the person
    public string _name;

    //Lets create a member variable to hold the list of jobs
    public List<Job> _jobs = new List<Job>();

    //lets add a method to the Resume class to display the resume details
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Job Experience:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
