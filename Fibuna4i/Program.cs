using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibuna4i
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("koe pod red 4islo na fibuna4i iskash da vkarassh:");
            byte numFib = byte.Parse(Console.ReadLine());
            List<int> num = new List<int>();
            num.Add(1);
            num.Add(1);
            
            
            for (int i = 2; i < numFib; i++)
            {
                num.Add(num[i-2]+ num[i-1] );
            }
            Console.WriteLine(string.Join(",",num));
        }
    }
}
