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

namespace CompareTriplets
{
    class Solution 
    {

        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b) 
        {
            int aliceScore=0, bobScore=0, totalTests=3;

            for(int i=0; i<totalTests; i++)
            {
                aliceScore += a[i] > b[i] ? 1 : 0;
                bobScore += a[i] < b[i] ? 1 : 0;
            }

            return new List<int> {aliceScore, bobScore};
        }

        static void Main(string[] args) 
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("CompareTriplets.txt"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}


