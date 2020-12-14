using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int i = 0;
        int j = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        
        string[] nStrings = new string[n];
        
        //reads in strings
        for(i=0;i<n;i++)
        {
            nStrings[i] = Console.ReadLine();
        }
        
        //prints the results of each string
        for (i=0;i<n;i++)
        {
            char[] temp = new char[nStrings[i].Length];
            //stores the nstrings[i] as a char array
            temp = nStrings[i].ToCharArray();
            
            //prints the even characters
            for (j=0;j<nStrings[i].Length;j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(temp[j]);
                }
            }
            
            //prints the space in the middle
            Console.Write(" ");
            
            //prints the odd characters
            for (j=0;j<nStrings[i].Length;j++)
            {
                if (j % 2 != 0)
                {
                    Console.Write(temp[j]);
                }
            }
            Console.WriteLine();
        }
    }
}
