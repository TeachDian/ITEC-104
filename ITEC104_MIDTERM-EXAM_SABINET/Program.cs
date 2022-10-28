using System.Collections;
using System.IO;


Stack stack = new Stack();
static void main()
{

}
do
{
    Console.Write(@"
    Stack MENU(size -- 10)
        1. Add an element
        2. See the Top Element
        3. Remove the Top Element
        4. Display Stack Elements
        5. Exit
    Select your Choice: ");

    switch (Console.Read())
    {
        case '1': Uno(); break;
        case '2': Dos(); break;
        case '3': Trs(); break;
        case '4': Qtr(); break;
        case '5': Cnc(); break;

        default: Console.WriteLine("\n    Invalid Input!"); break;
    }
    //Console.ReadKey();
} while (true);

static void Uno()
{

    Console.Write("    Enter the Element: ");
    string input = Console.ReadLine();
    int num = Convert.ToInt32(input);
    Console.Write("\n    Item Pushed Successfully!");
    Console.ReadKey();
}
static void Dos()
{

}
static void Trs()
{

}
static void Qtr()
{

}
static void Cnc()
{
    Console.Write(@"    Confirm Exit?");

}


//  1
// Enter the Element : 25
// Item Pushed Successfully!

// Select your choice :1
// Enter the Element : 26
// Item Pushed Successfully!

// Select your choice : 4
// Item 2 :26
// Item 1 :25

// Select your choice : 3
// Top of stack is removed!!
// New Top of stack is 25
