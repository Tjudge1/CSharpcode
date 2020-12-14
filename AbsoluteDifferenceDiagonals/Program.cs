using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
            byte numTests = byte.Parse(Console.ReadLine());
            sbyte [] auxiliar = new sbyte[numTests];
            short diag1 = 0, diag2 = 0;

            for (int i = 0; i < numTests; i++)
            {
                auxiliar = Array.ConvertAll(Console.ReadLine().Split(' '), sbyte.Parse);
                diag1 += auxiliar[i];
                diag2 += auxiliar[numTests-i-1];
            }
            Console.WriteLine(Math.Abs(diag1-diag2));
    }
}