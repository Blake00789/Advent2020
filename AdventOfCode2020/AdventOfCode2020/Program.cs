using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AdventOfCode2020
{
    class Program
    {
        static List<int> GetInput<Integer>(string file)
        {
            string url = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), file);
            List<int> output = new List<int>();

            using var reader = new StreamReader(url);

            while (!reader.EndOfStream)
            {
                var next = reader.ReadLine();
                var converted = int.Parse(next);
                output.Add(converted);
            }

            return output;

        }
        static void Main(string[] args)
        {
            var input = GetInput<int>("day1.txt");
            Console.WriteLine(Day1.Part2(input));
            Console.ReadLine();
        }
    }
}
