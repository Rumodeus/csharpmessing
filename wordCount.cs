using System;


public class App
{


    int CountWords(string message)
    {
        string[] messageArray = (message.Split(" "));
        return messageArray.Length;


    }


    static void Main(string[] args)
    {
        Console.WriteLine(new App().CountWords("Hi Julia!"));
    }
}