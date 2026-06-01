using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video(
            "Programming with Classes",
            "Idam Agha",
            600);

        video1.AddComment(new Comment("Emma", "Great tutorial!"));
        video1.AddComment(new Comment("Jane", "Very easy to understand."));
        video1.AddComment(new Comment("Sunny", "Thanks for sharing."));
        video1.AddComment(new Comment("Grace", "Helped me with my homework."));

        videos.Add(video1);

        // Video 2
        Video video2 = new Video(
            "Learn Object-Oriented Programming",
            "Tech Mentor",
            850);

        video2.AddComment(new Comment("David", "Excellent explanation."));
        video2.AddComment(new Comment("Lisa", "I finally understand classes."));
        video2.AddComment(new Comment("Chris", "Very informative."));
        video2.AddComment(new Comment("Anna", "Looking forward to more videos."));

        videos.Add(video2);

        // Video 3
        Video video3 = new Video(
            "Top 10 Productivity Tips",
            "Idam Agha",
            480);

        video3.AddComment(new Comment("Peter", "These tips are useful."));
        video3.AddComment(new Comment("Mary", "I use tip number 3 daily."));
        video3.AddComment(new Comment("James", "Great content."));
        video3.AddComment(new Comment("Ruth", "Thanks for the motivation."));

        videos.Add(video3);

        // Video 4
        Video video4 = new Video(
            "How to Start a Small Business",
            "Idam Agha",
            720);

        video4.AddComment(new Comment("Alex", "Very practical advice."));
        video4.AddComment(new Comment("Linda", "Exactly what I needed."));
        video4.AddComment(new Comment("Samuel", "Helpful information."));
        video4.AddComment(new Comment("Emma", "Thank you for sharing."));

        videos.Add(video4);

        // Display Videos
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}
