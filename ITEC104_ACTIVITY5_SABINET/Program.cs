internal class Program
{
    static void Main(string[] args)
    {
        List<int> xyz = test(new List<int>(new int[] {
            10, 20, 35, 65, 53, 48, 5, 1
            }));

        foreach (var x in xyz)
        {
            Console.Write(x.ToString() + " ");
        }
        Console.ReadKey();
    }
    public static List<int> test(List<int> nums)
    {
        return nums.Where(n => n % 10 != 5).ToList();
    }
}
