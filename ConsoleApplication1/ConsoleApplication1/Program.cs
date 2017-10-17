using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            fffff gg = new ConsoleApplication1.fffff();
            for (int i = 0; i < gg.ListOfAsk.Count; i++)
            {

                Console.WriteLine(gg.ListOfAsk[i].question);
            }
        }
    }
}
