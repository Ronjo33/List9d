using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("vuvedi kolko 4isla iskash:");
            int n = int.Parse(Console.ReadLine());
            List<int> num = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vuvedi cislo");
                int item = int.Parse(Console.ReadLine());
                num.Add(item);
            }
            ////v sreadta
            //int newindex = n / 2;
            //num.Insert(newindex, 6);
            ////dobavqne  v kraq na min element 
            //int minElement = num.Min();
            //num.Add(minElement);

            //da se iztrie nulite priqteli
            //foreach (var cehervenokv in num) 
            while(num.Contains(0))
            {
                num.Remove(0);
            }
            
            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine($"numbers[{i}] = {num[i]}");
            }
            Console.WriteLine("broq na elementite v spisuka e:" + num.Count);
        }
    }
}
