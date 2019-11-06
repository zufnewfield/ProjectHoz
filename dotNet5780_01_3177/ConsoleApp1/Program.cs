using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            string[] tafrit = { "Please enter your choise.\npress 1 to book", "press 2 to show bookings", "press 3 to show statistics", "press 4 to exit" };//new string[3];
            bool[,] arr = new bool[12, 31];            
            while (p != 4)
            {
                for (int i = 0; i < 4; i++)
                    Console.WriteLine(tafrit[i]);
                p = int.Parse(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        {
                            int a, b, m;
                            Console.WriteLine("First enter the month's number, then the start date, and then for how many days.");
                            m = int.Parse(Console.ReadLine());
                            a = int.Parse(Console.ReadLine());
                            b = int.Parse(Console.ReadLine());
                            isA(ref arr, m, a, b);
                            //Console.WriteLine("{0} {1} {2}", m, a, b);
                            break;
                        }
                    case 2:
                        {
                            for(int i=0;i<12;i++)
                            {
                                for (int j = 0; j < 31; j++)
                                {
                                    if (arr[i, j])
                                    {
                                        Console.Write("{0}/{1}-", j+1, i);
                                        for (; j < 31; j++)
                                        {
                                            if (!arr[i, j])
                                            {
                                                Console.Write("{0}/{1}\n", j , i);break;
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            int sum = 0; double prec;
                            for (int i = 0; i < 12; i++)
                            {
                                for (int j = 0; j < 31; j++)
                                {
                                    if (arr[i, j] == true)
                                    {
                                        sum = sum + 1;
                                    }
                                }
                            }
                            prec = (sum / 365) * 100;
                            Console.WriteLine("{0} days out of the 365 days are booked. which is {1} precents booked.", sum, prec);
                            break;
                        }
                }
            }
            Console.ReadKey();
        }
        static void isA(ref bool[,] arr, int m, int a, int b)
        {
            for (int i = a-1; i < a - 1 + b; i++)
            {
                if (arr[m, i]==true)
                {
                    Console.WriteLine("Request Denied");
                    return;
                }
            }
            Console.WriteLine("Request accepted");
            for (int i = a-1; i < a - 1 + b; i++)
            {
                arr[m, i] = true;
            }
            return;
        }
    }
    
}
