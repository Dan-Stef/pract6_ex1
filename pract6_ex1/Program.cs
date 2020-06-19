using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract6_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-dimensional array
            
            Random rnd = new Random();
            int [] array = new int[10];
            double counter = 0;
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 101);
                Console.WriteLine("["+i+"]: "+array[i]+" ");
                if (array[i] < 0)
                {
                    counter += array[i];
                    c++;
                }
            }
            counter = counter / c;
            Console.WriteLine("average amount of negative munbers: " + counter);

            // 2-dimensional array

            var arr2d = new int[10,10];
            counter = 0;
            c = 0;
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    arr2d[i,j] = rnd.Next(-100, 101);
                    Console.Write(arr2d[i,j] + " ");
                    if (arr2d[i,j]<0)
                    {
                        counter += arr2d[i,j];
                        c++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("average amount of negative munbers: " + counter/c);
            Console.ReadKey();
        }
    }
}
