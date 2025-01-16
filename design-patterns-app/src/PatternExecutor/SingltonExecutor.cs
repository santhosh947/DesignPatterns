using System;
using System.Threading.Tasks;

public class SingletonExecutor
{

    public static void BasicTests()
    {
        Singleton obj = Singleton.getInstance();
        obj.setData(5);
        Console.WriteLine(obj.getData());

        Singleton obj2 = Singleton.getInstance();
        Console.WriteLine(obj2.getData());
    }

    public static void ThreadSafeTests()
    {
        Parallel.For(0, 1000, i =>
        {
            Singleton instance = Singleton.getInstance();
            Console.WriteLine($"Instance ID: {instance.GetHashCode()}");
        });
    }
}