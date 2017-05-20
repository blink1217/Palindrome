using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindromes are Great!");

            string s = "sqrrqabccbatudefggfedvwhijkllkjihxymnnmzpop";
            List<string> st = new List<string>(); 

            for(int i = 0; i < s.Length; i++ )
            {
                for (int p = 0; p <= s.Length - i; p ++)
                {
                    if (s.Substring(i, p).SequenceEqual(s.Substring(i, p).Reverse())) st.Add(s.Substring(i, p)); 
                }

            }

            foreach (string str in st.OrderByDescending(e => e.Length).Take(3))
                Console.WriteLine(str + " : with index " + s.IndexOf(str));
            Console.ReadLine(); 

        }
    }
}