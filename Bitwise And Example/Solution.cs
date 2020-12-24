﻿using System;

namespace Bitwise_And_Example
{
using System;

//Thanks and credit goes to Jon_Chai
    class Solution {

        static void Main(string[] args) {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr=0;tItr<t;tItr++) {
                string[] nk = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(nk[0]);
                int k = Convert.ToInt32(nk[1]);
                int result = 0;
                for(int i=1;i<=n;i++){
                    for(int j=1;j<=n;j++){
                        if (i == j){
                            continue;
                        }
                        int and = (i&j);
                        if (and<k&&and>result){
                            result = and;
                        }
                    }   
                }
                Console.WriteLine(result); 
            }
        }
    }
}
