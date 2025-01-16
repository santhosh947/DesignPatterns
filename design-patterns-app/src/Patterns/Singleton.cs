using System;

public class Singleton
{
    private static Singleton Instance;
    private int data;
    private static readonly object padlock = new object();


    private Singleton()
    {
        Console.WriteLine("Private Constructor - Singleton object is being created");
    }

    public static Singleton getInstance()
    {
        if (Instance == null)
        {
            lock (padlock)
            {
                if (Instance == null)
                {
                    Instance = new Singleton();
                    Console.WriteLine("Singleton Instance is created");
                }
            }
        }
        return Instance;
    }

    public void setData(int data)
    {
        this.data = data;
    }

    public int getData()
    {
        return data;
    }
}