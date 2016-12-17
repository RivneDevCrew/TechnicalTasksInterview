using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        delegate char[] CharArrDelegate(char[] s);

        static void Benchmark(string description, CharArrDelegate d, int times, char[] text) // getting timings
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int j = 0; j < times; j++)
            {
                d(text);
            }
            sw.Stop();
            Console.WriteLine("{0}  {1} : called {2} times.", sw.Elapsed, description, times);
        }
        public static char[] StringOfLength(int length) // function helper to create random string with {length} symbols
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))));// just get random char
            }
            return sb.ToString().ToCharArray();
        }
        public static char[] ReverseXOR(char[] str)
        {
            
            int length = str.Length - 1;

            for (int i = 0; i < length; i++, length--)
            {
                str[i] ^= str[length];
                str[length] ^= str[i];
                str[i] ^= str[length];
            }

            return str;
        }

        public static char [] ReverseSB(char[] text)
        {
            StringBuilder builder = new StringBuilder(text.Length);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                builder.Append(text[i]);
            }
            text = builder.ToString().ToCharArray();
            return text;
        }
        public static char[] ReverseArray(char [] text)
        {
            
            Array.Reverse(text);
            return text;
        }
        public static char [] ReverseArrayManually(char[] text)
        {
            char tmp;
            int end = text.Count();
            for (int i = 0; i < end / 2; i++)
            {
                tmp = text[i];
                text[i] = text[end - i - 1];
                text[end - i - 1] = tmp;

            }
            return text;

        }

        static void Main(string[] args)
        {

            int[] lengths = new int[] { 1, 10, 25, 50, 100, 1000, 100000 };

            Console.WriteLine("Test");
            char[] str = "Hello world!".ToCharArray();
            Console.WriteLine(ReverseSB(str)); // value not changed
            Console.WriteLine(ReverseXOR(str)); // value reversed
            Console.WriteLine(ReverseArray(str)); // value reversed
            Console.WriteLine(ReverseArrayManually(str)); // value reversed 
            foreach (int l in lengths)
            {
                int iterations = 10000;
                char[] text = StringOfLength(l);
                Benchmark(String.Format("String Builder (Length: {0})", l), ReverseSB, iterations, text); // the slowest on long distances
                Benchmark(String.Format("Array.Reverse (Length: {0})", l), ReverseArray, iterations, text); // a bit slow on short distances comparing to XOR, but the fastest further
                Benchmark(String.Format("Xor (Length: {0})", l), ReverseXOR, iterations, text); //  the fastest on short distances
                Benchmark(String.Format("Reverse Char Array (Length: {0})", l), ReverseArrayManually, iterations, text); //  the second one after array.reverse() in long string cases, but the third one for short strings

                Console.WriteLine();
            }


            


        }
    }
}
