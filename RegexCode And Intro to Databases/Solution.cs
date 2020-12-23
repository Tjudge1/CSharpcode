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

namespace RegexCode_And_Intro_to_Databases
{

    class Solution {

        //thanks TopsyCretts
        static void Main(string[] args)
        {
            //Simulates a database table, Emails, which has the attributes 
            //First Name and Email ID. Given N rows of data simulating the Emails          //table. Program prints an alphabetically-ordered list of people whose         //email address ends in Gmail.com
        
            int N = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            string[] names = new string[N];
        
            for (int i=0;i<N;i++)
            {
                string[] tokens_firstName = Console.ReadLine().Split(' ');
                string firstName = tokens_firstName[0];
                string emailID = tokens_firstName[1];

                if (emailID.EndsWith("@gmail.com"))
                {
                    names[j] = firstName;
                    j++;
                }
            }

            Array.Sort(names);
            for (int i=0;i<names.Length;i++)
            {
                if (names[i] != null)
                {
                    Console.WriteLine(names[i]);
            }
            }
        }
    }
}