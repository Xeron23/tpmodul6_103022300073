using System;
public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    private Random random = new Random();
    public SayaTubeVideo(string title)
    {
        this.title = title;
        playCount = 0;
        id = random.Next(10000, 100000);
    }

    public void IncreasePlayCount(int play)
    {
        playCount += play;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("id: " + id + ", Title: " + title + ", play: " + playCount);
    }
}

public class Program
{
    public static void Main()
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - [Muhammad Rifki Anandita]");
        video1.IncreasePlayCount(10);
        video1.PrintVideoDetails();
    }
}
