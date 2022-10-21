using System.Collections;
Stack st = new Stack();
st.Push('A');
st.Push('M');
st.Push('G');
st.Push('W');

Console.WriteLine("Current Stack: ");
foreach (char c in st)
{
    Console.Write(c + " ");
}
Console.WriteLine();
st.Push('H');
st.Push('V');
Console.WriteLine("The next poppable value in stack: {0} ", st.Peek());
Console.WriteLine("urrent stack: ");
foreach (char c in st)
{
    Console.Write(c + " ");
}
Console.WriteLine();
Console.WriteLine("Removing values ");
st.Pop();
st.Pop();
st.Pop();
Console.WriteLine("Current stack: ");
foreach (char c in st)
{
    Console.Write(c + " ");
}
Console.ReadKey(true);