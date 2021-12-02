using System;
using System.Linq;

namespace AdventOfCode.Day02;

public class Solution : BaseSolution
{
    public Solution() : base(2, "Dive!")
    {
    }

    public override string GetPart1Answer()
    {
        int position = 0;
        int depth = 0;

        foreach(var input in GetResourceString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries))
        {
            int mod = int.Parse(new string(input.Where(c => char.IsDigit(c)).ToArray()));
            if(input[0] == 'f')
            {
                position += mod;
            }
            else if(input[0] == 'd')
            {
                depth += mod;
            }
            else if(input[0] == 'u')
            {
                depth -= mod;
            }
        }
        return (position * depth).ToString();
    }

    public override string GetPart2Answer()
    {
        int position = 0;
        int depth = 0;
        int aim = 0;

        foreach (var input in GetResourceString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries))
        {
            int mod = int.Parse(new string(input.Where(c => char.IsDigit(c)).ToArray()));
            if (input[0] == 'f')
            {
                position += mod;
                depth += aim * mod;
            }
            else if (input[0] == 'd')
            {
                aim += mod;
            }
            else if (input[0] == 'u')
            {
                aim -= mod;
            }
        }
        return (position * depth).ToString();
    }
}
