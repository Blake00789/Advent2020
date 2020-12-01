using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020
{
    class Day1
    {
        public static int Part1(List<int> input)
        {
            Dictionary<int, int> entries = new Dictionary<int, int>();
            //converting to a dict gives us O(1) access
            foreach (var item in input)
            {
                entries.Add(item, 0);
            }

            foreach(var entry in input)
            {
                var pair = 2020 - entry;
                if (entries.ContainsKey(pair))
                {
                    return pair * entry;
                }
            }

            return 0;
        }

        public static int Part2(List<int> input)
        {
            Dictionary<int, int> entries = new Dictionary<int, int>();
            //converting to a dict gives us O(1) access
            foreach (var item in input)
            {
                entries.Add(item, 0);
            }

            foreach (var firstentry in input)
            {
                foreach (var secondentry in input)
                {
                    if (firstentry == secondentry)
                    {
                        continue;
                    }

                    var thirdentry = 2020 - (firstentry + secondentry);
                    if (entries.ContainsKey(thirdentry))
                    {
                        return firstentry * secondentry * thirdentry;
                    }
                }
            }

            return 0;
        }
    }
}
