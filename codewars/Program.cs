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

     
        Console.WriteLine(Remove("Hi!!!", 1));

    }



    public static string Remove(string s, int n)
    {
        int count = n;
        string answer = "";
        char[] splitStr = s.ToCharArray();
        for (int i = 0; i < splitStr.Length; i++)
        {
            if (count > 0 && splitStr[i] == '!')
            {
                count--;
            } else answer += splitStr[i];



        }

        return answer;
    }

}