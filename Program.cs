using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int num = 0;
            double n = 0.0;
            string w = " ";

            Console.Write("Enter the opcion 1, 2 or 3: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine(" Enter one number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    num += 1;
                    Console.WriteLine(" The increased number: {0} ", num);
                    break;
                case 2:
                    Console.WriteLine(" Enter one number: ");
                    n = Convert.ToDouble(Console.ReadLine());
                    n += 1;
                    Console.WriteLine(" The increased number: {0} ", n);
                    break;
                default:
                    Console.WriteLine(" Enter one word: ");
                    w = Console.ReadLine();
                    Console.WriteLine(" The  modified word:" + w + "*");
                    break;
            }

            Console.ReadKey();
        }
    }
}
