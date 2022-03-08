Action<int, int> print = (a, b) => { for (int i = a; i <= b; i++) Console.WriteLine(i); };


/* Here creae a thread to use the print method to be executed within the thread. */