using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] test = new int[10]
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] res = GetEvenNumbers(test);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
        public static int[] GetEvenNumbers(int[] arr)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] & 1) == 0) // check last byte
                    res.Add(arr[i]);
            }
            return res.ToArray();
        }
    }
}
