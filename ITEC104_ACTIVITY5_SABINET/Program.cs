// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         IList<int> list = new List<int>(){
//             10, 20, 35 , 65, 53, 48 , 5, 1
//         };

//         foreach (var item in list)
//         {
//             for (int i = 0; i < 5; i++)
//             {
//                 Console.WriteLine(item);
//                 Console.ReadKey();
//             }

//         }


//     }
//     public static List<int> test(List<int> nums)
//     {
//         return nums.Where(n => n % 10 < 5).ToList();
//         //Console.WriteLine(test);
//     }

// }

internal class Calculator
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
        return nums.Where(n => n % 10 < 5).ToList();
    }
}