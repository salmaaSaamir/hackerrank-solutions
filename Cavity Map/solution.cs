using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'cavityMap' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts STRING_ARRAY grid as parameter.
     */

  public static List<string> cavityMap(List<string> grid)
{
    List<string> result = new List<string>();

    for (int row = 0; row < grid.Count; row++)
    {
        char[] chars = grid[row].ToCharArray();

        if (row > 0 && row < grid.Count - 1)
        {
            for (int col = 1; col < grid[row].Length - 1; col++)
            {
                char current = grid[row][col];
                char up = grid[row - 1][col];
                char down = grid[row + 1][col];
                char left = grid[row][col - 1];
                char right = grid[row][col + 1];

                if (current > up && current > down && current > left && current > right)
                {
                    chars[col] = 'X';
                }
            }
        }

        result.Add(new string(chars));
    }

    return result;
}

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> grid = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string gridItem = Console.ReadLine();
            grid.Add(gridItem);
        }

        List<string> result = Result.cavityMap(grid);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
