using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_01_3177
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr1 = new Int32[20];
            Int32[] arr2 = new Int32[20];
            Int32[] arr3 = new Int32[20];
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                arr1[i] = r.Next(18, 122);
                arr2[i] = r.Next(18, 122);
                if (arr1[i] > arr2[i])
                {
                    arr3[i] = arr1[i] - arr2[i];
                }
                else
                {
                    arr3[i] = arr2[i] - arr1[i];
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,4} ", arr1[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,4} ", arr2[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,4} ", arr3[i]);
            }
            Console.ReadKey();
        }
    }
}
