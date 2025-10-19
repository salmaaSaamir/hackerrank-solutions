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
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

    public static void kaprekarNumbers(int p, int q)
    {     
           List<int> kaprekarList = new List<int>();

           for (int i = p; i <= q; i++)
        {
            long square = (long)i * i;
            string s = square.ToString();
            int len = s.Length;

            string leftPart = s.Substring(0, len / 2);
            string rightPart = s.Substring(len / 2);

            int left = string.IsNullOrEmpty(leftPart) ? 0 : int.Parse(leftPart);
            int right = string.IsNullOrEmpty(rightPart) ? 0 : int.Parse(rightPart);

            if (left + right == i)
                kaprekarList.Add(i);
        }

        if (kaprekarList.Count > 0)
            Console.WriteLine(string.Join(" ", kaprekarList));
        else
            Console.WriteLine("INVALID RANGE");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}
