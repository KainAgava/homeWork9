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
            int startCycle;
            int variableCycle = 7;
            int cycleCeiling = 100;
            //for т.к. известные "рамки" цикла
            for (startCycle = 5; startCycle < cycleCeiling; startCycle += variableCycle)
            {
                Console.WriteLine(startCycle);
            }
        }
    }
}
