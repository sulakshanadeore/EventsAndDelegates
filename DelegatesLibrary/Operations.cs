using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLibrary
{
    public delegate string JoinStrings(string s1, string s2);
    public class Operations
    {
        public string ConcatStrings(string s1, string s2) 
        {
            Console.WriteLine("Working on concatenation.....");
            Thread.Sleep(1000);
            

            return string.Concat(s1, s2);   


        }


    }
}
