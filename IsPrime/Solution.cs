using System;
using System.Collections.Generic;
using System.IO;

namespace IsPrime
{

    class Solution {
        static void Main(String[] args) 
        {
            /* Enter your code here. Read input from STDIN. 
            Print output to STDOUT. 
            Your class should be named Solution */
        
            //Number of times to read in user input
            int T = Convert.ToInt32(Console.ReadLine());
            //Declaring n, which is an indiviual number to check later.
            int n;
            //this is going to be a string that we return as prime or not prime.
            string result;
    
            //recurssion time. Read in a seperate input for T number of times
            for(int i=1;i<=T;i++)
            {
                //assign a user input for n per each recurrsion.
                n = Convert.ToInt32(Console.ReadLine());
                //double recurrsion for checking if prime
                //We start at the smallest unit that can create a prime number,              
                //2, which when multiplied by itself makes 4, the smallest prime             
                //number.
                for(int j=2;j<=n/j;j++)
                {
                    //modular operation to verify if its prime
                    if(n % j == 0)
                    {
                        //Heh, a little trick to exit out of the nested loop
                        //We don't actually need to save an array at all.
                        //n can now be repurposed for a sort of truth condition.
                        //Which will also break the loop since n = 1 is smaller                      
                        //than 2, which is the initial condition for j.
                        n = 1;
                    }
                }
                //So, returning to the first recurssive loop, we check to see if             
                //n == 1, which it'll never be normally (we hope?).
                //And here we have an if statement in one line. Left is false                
                //condition, right is true condition so, n == 1 true = WriteLine             
                //"Prime"; The syntax might appear strange at first, it works                
                //though, don't overthink it too much.
                result = n == 1?"Not prime":"Prime";
                Console.WriteLine(result);
            }
        }
    }
}