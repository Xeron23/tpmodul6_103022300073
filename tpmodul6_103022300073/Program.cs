using System;
using System.Diagnostics;
public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    private Random random = new Random();
    public SayaTubeVideo(string title)
    {
        Debug.Assert(!string.IsNullOrEmpty(title), "Judul video tidak boleh null atau kosong.");
        Debug.Assert(title.Length <= 100, "Judul video tidak boleh lebih dari 100 karakter.");
        this.title = title;
        playCount = 0;
        id = random.Next(10000, 100000);
    }

    public void IncreasePlayCount(int play)
    {
        Debug.Assert(play > 0 && play <= 10000000, "Play count harus di antara 1 hingga 10.000.000.");
        try
        {

            checked
            {
                playCount += play;
            }

        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas integer maksimum!");
        }
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
        try
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Tutorial Design By Contract - [Muhammad Rifki Anandita]");
            video1.IncreasePlayCount(10);


            SayaTubeVideo video2 = new SayaTubeVideo("Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]Tutorial Design By Contract - [Muhammad Rifki Anandita]");

            //SayaTubeVideo video3 = new SayaTubeVideo(null);


            video1.IncreasePlayCount(20000000);

            for (int i = 0; i < 10; i++)
            {
                video1.IncreasePlayCount(int.MaxValue);
            }





            video1.PrintVideoDetails();
        }
        catch (Exception e)
        {

        }
        

    }
}
