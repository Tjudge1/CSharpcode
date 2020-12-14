using System;
using System.Collections.Generic;
using System.IO;
class Program {
    static void Main(String[] args) {
        
        Dictionary<string, long> phoneBook = new Dictionary<string, long>();
        
        string input = Console.ReadLine();
        long n = Convert.ToInt64(input);
        
        for (int i = 0; i < n;i++)
            {
            string[] values = Console.ReadLine().Split(' ');
            string name = values[0];
            long number = Convert.ToInt64(values[1]);
            
            phoneBook.Add(name, number);            
        }
        
        for (int i=0;i<n;i++)
            {
            string check = Console.ReadLine();
            if (phoneBook.ContainsKey(check))
            {
                long output = phoneBook[check];
                Console.WriteLine("{0}={1}", check, output);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}