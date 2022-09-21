// See https://aka.ms/new-console-template for more information
Console.Title = "Activity 3";
Console.ForegroundColor = ConsoleColor.Green;


string[] Username = {
"juan","juto","jutri","jupor"
};
string[] Password = {
"password1","password2","password3","password4",
};
string[] Email = {
"juan@sabinet.com","juto@sabinet.com","jutri@sabinet.com","jupor@sabinet.com"
};

int x;
do
{
    try
    {
        Console.Write("INDEX: ");
        x = Convert.ToInt32(Console.ReadLine());
        try
        {
            //i added 1 to the base index to make more sense for normal person and to avoide confusion
            Console.WriteLine("USERNAME: " + Username[x - 1]);
            Console.WriteLine("PASSWORD: " + Password[x - 1]);
            Console.WriteLine("EMAIL: " + Email[x - 1]);
            Console.ReadKey();
            Console.Clear();

        }
        catch (System.Exception)
        {
            //Console.WriteLine("NO DATA AVAILBLE!");
            throw;
        }
    }
    catch (System.Exception)
    {
        //Console.WriteLine("INVALID INPUT!");
        throw;

    }


} while (true);


