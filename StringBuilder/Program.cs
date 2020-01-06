using System;
using System.Collections.Generic;

namespace StringBuilderTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShowOutput();
            Console.ReadKey(true);
        }

        private static void ShowOutput()
        {
            //Calculate Output
            string output = "*";

            var sb = new System.Text.StringBuilder();
            List<string> list = new List<string>();

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(sb.Append(output) + "\n");
            }
        }
    }
}
