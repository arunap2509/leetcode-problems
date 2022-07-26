namespace Leetcode.Stack;

public class ValidParantheses
{
    public static bool Solution(string s)
    {
        Stack<char> stack = new();
        var closingParanthese = "]})";
        var dict = new Dictionary<char, char>
        {
            { '{', '}' },
            { '[', ']' },
            { '(', ')' }
        };

        foreach (var ch in s)
        {
            if (closingParanthese.Contains(ch))
            {
                if (stack.Count == 0 || stack.Pop() != ch)
                {
                    return false;
                }
            }
            else
            {
                stack.Push(dict[ch]);
            }
        }

        return stack.Count == 0;
    }
}

