// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string code = "534222244";

        Regex regex = new Regex("^[1-3]");
        Console.WriteLine(regex.IsMatch(code));

        int[][] stairsData = new int[][] { new int[] { 1, 2, 3 }, new int[] { 112, 23, 123 } };

        List <int> testData = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine(String.Join(",",Odds(testData)));
        List<int> odds = Odds(testData);
        Console.WriteLine(string.Join(", ", odds));

    }



    public static List<int> Odds(List<int> values) =>
    // arrow it
    values.Where( value=> value%2==1)
          .ToList();

}