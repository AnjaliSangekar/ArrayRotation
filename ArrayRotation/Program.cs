using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Left rotation");
            var ar = new[] {1, 2, 3, 4, 5 };
            Left(ar);
            Console.WriteLine("Right rotation");
            var arr = new[] { 1, 2, 3, 4, 5 };
            Right(arr);
        }

        public static void Left(int[] a)
        {
            
            int size = a.Length;
            int temp;

            for(int i = size-1; i > 0; i--)
            {
                temp = a[size - 1];
                a[size - 1] = a[i - 1];
                a[i - 1] = temp;
            }

            foreach(int num in a)
            {
                Console.Write(num + " ");
               
            }
            Console.WriteLine();
        }

        
        public static void Right(int[] a)
        {
            int size = a.Length;
            int temp;

            for(int i = 0; i < size-1; i++)
            {
                temp = a[0];
                a[0] = a[i + 1];
                a[i + 1] = temp; 
            }

            foreach(int num in a)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
