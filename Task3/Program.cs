
public class Program
{

   public static Dictionary<string, int> Name_Age = new Dictionary<string, int>();
    public static void Main(string[] args)
    {
        int[] ages = new int[] { 23, 45, 23, 95, 83, 25, 82, 67, 54 };
        string[] names = new string[] { "minu", "rashed", "tina", "tareq", "habib", "emon",
"araf", "rafiq", "munna"};
        dictionaryMethod( ages, names);
        PrintdictionaryMethod();
    }

    public static void dictionaryMethod(int[] ages, string[] names)
    {
       for(int i = 0; i < ages.Length; i++)
        {
            Name_Age.Add(names[i], ages[i]);
        }

    }

    public static void PrintdictionaryMethod()
    {
        foreach (KeyValuePair<string, int> value in Name_Age)
        {
            Console.WriteLine("Name: {0}, Age: {1}", value.Key, value.Value);
        };
    }



}

/* Create a dictionary, use names as key of the dictionary and ages as values in the dictionary. 
 * You can asume first age belongs to first name in the array and 2nd age belongs to 2nd name
 * and so on...
 */
