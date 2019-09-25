using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_1_to_10_number_with_Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);
        }
    }
}
