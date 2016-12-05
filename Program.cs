using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            int inputNum = Convert.ToInt32 ( Console.ReadLine ( ) );

            int totalNum = 0;
            for (int i = 1 ; i <= inputNum ; i++)
            {
                totalNum = totalNum + 3 * i -1;
            }

            Console.WriteLine ( totalNum );
        }
    }
}
