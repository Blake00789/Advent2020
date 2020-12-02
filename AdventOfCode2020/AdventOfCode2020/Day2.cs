using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020
{
    class Day2
    {
        public static int Part1 (List<String> input)
        {
            var valid = 0;

            foreach (var password in input)
            {
                var count = 0;

                var split = password.Split(" ");

                var limit = split[0].Split("-");
                var lowerlimit = int.Parse(limit[0]);
                var upperlimit = int.Parse(limit[1]);

                var character = split[1][0];


                foreach (var check in split[2])
                {
                    if (character == check)
                    {
                        count += 1;
                    }

                    //could break early if count > upper but it doesn't matter much
                }

                if (count >= lowerlimit && count <= upperlimit)
                {
                    valid += 1;
                }
            }

            return valid;
        }

        public static int Part2 (List<String> input)
        {
            var valid = 0;

            foreach (var password in input)
            {
                var split = password.Split(" ");

                var positions = split[0].Split("-");
                var lowerpos = int.Parse(positions[0]) - 1;
                var upperpos = int.Parse(positions[1]) - 1;

                var character = split[1][0];


                //hope they are nice enough to not give passwords too small
                //edit: they aren't.
                var query = split[2];
                var lowerchar = lowerpos < query.Length && query[lowerpos] == character;
                var upperchar = upperpos < query.Length && query[upperpos] == character;


                if ((lowerchar && !upperchar) || (!lowerchar && upperchar))
                {
                    valid += 1;
                }
            }

            return valid;
        }
    }
}
