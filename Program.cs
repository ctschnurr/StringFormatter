using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StringFormatter
{
    internal class Program
    {

        static string story = "This is my story. It is a very long story and will be treated as if pulled in from an outside file and needs to be treated in some way, so that my program can then properly display it on a page in order to create an interactive fiction experience.";

        static void Main(string[] args)
        {
            Console.WriteLine(story);
            Console.ReadKey(true);

        }
    }
}
