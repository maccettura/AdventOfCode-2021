using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day01;

public class Solution : BaseSolution
{
    public Solution() : base(1, "Sonar Sweep")
    {
    }

    public override string GetPart1Answer()
    {
        int[] input = GetResourceString()
            .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

        int count = 0;
        int previous = input[0];
        foreach (int i in input.Skip(1))
        {
            if (i > previous)
            {
                count++;
            }
            previous = i;
        }
        return count.ToString();
    }

    public override string GetPart2Answer()
    {
        const int windowSize = 3;

        int[] input = GetResourceString()
            .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

        var windowSums = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (i > input.Length - windowSize)
            {
                break;
            }
            windowSums.Add(input.Skip(i).Take(windowSize).Sum());
        }

        int count = 0;
        int previous = windowSums[0];
        foreach (int i in windowSums.Skip(1))
        {
            if (i > previous)
            {
                count++;
            }
            previous = i;
        }

        return count.ToString();
    }
}