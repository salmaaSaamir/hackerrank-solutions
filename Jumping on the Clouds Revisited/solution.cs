using System;
using System.IO;
using System.Linq;

class Solution
{
    static int jumpingOnClouds(int[] c, int k)
    {
        int energy = 100;
        int n = c.Length;
        int i = 0;

        do
        {
            i = (i + k) % n;

            energy -= (c[i] == 1) ? 3 : 1;

        } while (i != 0);

        return energy;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);
        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

        int result = jumpingOnClouds(c, k);

        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
