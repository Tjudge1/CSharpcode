using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BubbleSort
{

    class Solution {

        static void Main(String[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp,Int32.Parse);
            // Write Your Code Here
        
            int totalSwaps = 0;
        
            for (int i=0;i<n;i++) 
            {
            // Track number of elements swapped during a single array           //traversal
                int numberOfSwaps = 0;
                int tB;
                int tB1;
    
                for (int j=0;j<n-1;j++) {
                // Swap adjacent elements if they are in decreasing                 //order
                    if (a[j] > a[j + 1]) 
                    {
                        tB = a[j]; 
                        tB1 = a[j+1];
                        a[j] = tB1;
                        a[j+1] = tB;
                        numberOfSwaps++;
                        totalSwaps++;
                    }
                }
    
                // If no elements were swapped during a traversal,                  //array is sorted
                if (numberOfSwaps == 0) 
                {
                    break;
                }
            }
        
            Console.WriteLine("Array is sorted in " + totalSwaps + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[n-1]);
        
        }
    }
}