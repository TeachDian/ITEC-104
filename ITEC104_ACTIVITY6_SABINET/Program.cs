while (true)
{
    HashSet<int> h1 = new HashSet<int>();
    for (int i = 0; i < 5; i++)
    {
        Console.Write("Element: ");
        h1.Add(Convert.ToInt32(Console.ReadLine()));
    }
    Console.WriteLine();
    HashSet<int> h2 = new HashSet<int>();
    for (int i = 0; i < 5; i++)
    {
        Console.Write("Element: ");
        h2.Add(Convert.ToInt32(Console.ReadLine()));
    }
    Console.WriteLine();
    HashSet<int> h3 = new HashSet<int>(h1);
    h3.UnionWith(h2);
    foreach (int i in h3)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    HashSet<int> h4 = new HashSet<int>(h1);
    h4.IntersectWith(h2);
    foreach (int i in h4)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    HashSet<int> h5 = new HashSet<int>(h1);
    h5.ExceptWith(h2);
    foreach (int i in h5)
    {
        Console.Write(i + " ");
    }
    Console.Read();
}