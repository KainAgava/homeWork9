using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j = 7;
            int max = 100;
            //for т.к. известные "рамки" цикла
            for (i = 5; i < max; i += j)
            {
                Console.WriteLine(i);
            }
        }
    }
}
