using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() {
                    "Y",
                    "A",
                    "F",
                    "​Z"
                };

            list = list.OrderBy(x => x).ToList();

            list.ForEach(x => Debug.Print(x));
        }
    }
}
