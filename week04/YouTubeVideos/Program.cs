using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayVideoInfo(Video video)
        {
            int minutes = video.GetLengthSeconds() / 60;
            int seconds = video.GetLengthSeconds() % 60;
            string videoLength = $"{minutes}: {seconds:D2}";

            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"{videoLength}");
            Console.WriteLine($"Total number of comments: {video.GetNumberOfComment()}");
            Console.WriteLine($"\nComments:");

            int commentNumber = 1;
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {commentNumber}. {comment.GetCommenterName()}: {comment.GetComment()}");
                commentNumber++;
            }
        }

        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Tutorial for Beginners", "Programming with Mosh", 720);
        video1.AddComment("Alice", "Great tutorial!");
        video1.AddComment("Bob", "Very helpful, thanks!");
        video1.AddComment("Charlie", "I learned a lot from this.");
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("How to Make Pancakes", "Cooking Channel", 360);
        video2.AddComment("Dave", "Tried this recipe - delicious!");
        video2.AddComment("Eve", "My family loved it!");
        video2.AddComment("Frank", "Can I substitute milk with almond milk?");
        video2.AddComment("Grace", "Perfect for Sunday breakfast");
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Morning Yoga Routine", "Yoga with Adriene", 900);
        video3.AddComment("Heidi", "This is my daily routine now");
        video3.AddComment("Ivan", "Helped me with my back pain");
        video3.AddComment("Judy", "Namaste 🙏");
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Travel Guide: Japan", "Travel Vlogs", 1125);
        video4.AddComment("Kevin", "Planning my trip now!");
        video4.AddComment("Linda", "Beautiful cinematography");
        video4.AddComment("Mike", "What camera do you use?");
        videos.Add(video4);  
        
        // Display information for all videos
        foreach (var video in videos)
        {
            Console.WriteLine("___________________________________________");
            DisplayVideoInfo(video);
        }
    }
}