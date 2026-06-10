public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself through this experience?"
    };

    private List<string> ShuffleQuestions()
    {
        Random random = new Random();

        return _questions.OrderBy(q => random.Next()).ToList();
    }

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity will help you reflect on times when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        List<string> availableQuestions = ShuffleQuestions();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int questionIndex = 0;

        while (DateTime.Now < endTime)
        {
            if (questionIndex >= availableQuestions.Count)
            {
                availableQuestions = ShuffleQuestions();
                questionIndex = 0;
            }

            Console.WriteLine();
            Console.WriteLine(availableQuestions[questionIndex]);

            questionIndex++;

            ShowSpinner(5);
        }
    }
}
