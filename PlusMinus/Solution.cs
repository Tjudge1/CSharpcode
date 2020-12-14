using System;

namespace PlusMinus
{
    class Solution {

        // Complete the plusMinus function below.
        static void plusMinus(int[] arr) {
        
            // Store the array length into the variable len. 
            int len = arr.Length; 
   
            // Initialize the postiveCount, negativeCount, and 
            // zeroCountby 0 which will count the total number 
            // of positive, negative and zero elements 
            float positiveCount = 0; 
            float negativeCount = 0; 
            float zeroCount = 0; 
   
            //for loop for counting the elements in the array
            for (int i = 0; i < len; i++) { 
                if (arr[i] > 0) { 
                    positiveCount++; 
                } 
                else if (arr[i] < 0) { 
                    negativeCount++; 
                } 
                else if (arr[i] == 0) { 
                    zeroCount++; 
                } 
            } 
            
            // Print the ratio of positive, negative, and zero
            // from the array, and up to six decimal places. 
            Console.WriteLine("{0:F6} ", positiveCount / len); 
            Console.WriteLine("{0:F6} ", negativeCount / len); 
            Console.WriteLine("{0:F6} ", zeroCount / len); 
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
    }
}