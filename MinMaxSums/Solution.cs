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

class Solution {

    // Complete the miniMaxSum function below.
    static void miniMaxSum(long[] arr) {
        long[] sums = new long[5];
        int i = 0;
        long min = 0;
        long max = 0;
        for (i=0;i<5;i++)
        {
            sums[i] = (arr[0] + arr[1] + arr [2] + arr[3] + arr[4] - arr[i]); 
            if (min == 0)
            {
                min = sums[i];
            }
            else if (sums[i] < min) 
            {
                min = sums[i];
            }
            
            if (max == 0) 
            {
                max = sums[i];
            } 
            else if (sums[i] > max)
            {
                max = sums[i];
            }
        }
        Console.Write(min + " " + max);
        Console.WriteLine();
    }

    static void Main(string[] args) {
        long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
