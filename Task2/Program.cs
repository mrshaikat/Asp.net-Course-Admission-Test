using System.Threading.Tasks;

public class Program
{

    public static void Main(string[] args)
    {
        var syncTask = Task.Run(() =>
          {
            Action<int, int> print2 = print;
            print2(1, 5);

          });
        syncTask.Wait();
    }

    public static void print(int a, int b)
    {
        for (int i = a; i <= b; i++)
        {
            Console.WriteLine(i);

        }
    }

/* Here creae a thread to use the print method to be executed within the thread. */