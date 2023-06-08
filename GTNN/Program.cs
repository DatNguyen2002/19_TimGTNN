using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTNN
{

    internal class Program
    {
        public static int MinValue(int[] array)
        {

            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }

            return index;
        }
        public static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 56, 1, 5, 10 };
            int index = MinValue(array);
            Console.WriteLine(array[index]);


            int[] mang = { 5, 3, 9, 10, 7 };
            int giaTriNhoNhat = mang.Min();
            Console.WriteLine("Giá trị nhỏ nhất trong mảng là: " + giaTriNhoNhat);
            Console.ReadKey();
        }
    }
}
