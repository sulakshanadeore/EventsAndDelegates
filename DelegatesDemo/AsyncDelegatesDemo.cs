using DelegatesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class AsyncDelegatesDemo
    {
        static void Main(string[] args)
        {

            Operations o = new Operations();
            JoinStrings joinstr=new JoinStrings(o.ConcatStrings);
            string s=joinstr.Invoke("Hello ", "World");
            Console.WriteLine(s);
            //   IAsyncResult res   =joinstr.BeginInvoke("Hello ", "World!!!!", null, null);
            //      Console.WriteLine("Some other methods called from the main method.." +
            //        " so we are not blocking the main thread");
            // if (res.IsCompleted)
            // { 
            //string output= joinstr.EndInvoke(res);
            //     Console.WriteLine(output);


            // }

            Console.ReadLine();
        }
    }
}
