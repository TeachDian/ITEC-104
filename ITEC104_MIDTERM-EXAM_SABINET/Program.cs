using System.Collections;
Console.Title = "Midterm Exam";
Console.ForegroundColor = ConsoleColor.White; // you can change the foreground color here. Foreground = letters||
Stack stack = new Stack();
int Input;
Console.Write(@"
Stack MENU(size -- 10)
    1. Add an element
    2. See the Top Element
    3. Remove the Top Element
    4. Display Stack Elements
    5. Exit
");
while (true)
{
    Console.Write("Select your Choice: ");
    Input = Convert.ToInt32(Console.ReadLine());

    if (Input == 1)
    {
        Console.Write("Enter the Element: ");
        stack.Push(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Item Pushed Successfully!\n");
    }

    if (Input == 2)
    {      
        Console.WriteLine("Top of stack is {0}\n", stack.Peek());
    }

    if (Input == 3)
    {
        Console.WriteLine("Top of stack is removed!!", stack.Pop());
        Console.WriteLine("New Top of stack is {0}\n",  stack.Peek());
    }

    if (Input == 4)
    {
        foreach (int sanaall in stack)
        {
            Console.Write("Item: " +sanaall+"\n");
        }
        Console.WriteLine();
    }

    if (Input == 5)
    {
        Environment.Exit(0);
    }

    if (Input > 5)
    {
        Console.WriteLine("Invalid Input!\n");   
    }
}
