using System.Collections;

namespace Solve_5_Any_LeetCode_Questions
{
    internal class ValidParentheses
    {
        static public bool IsValid(string s)
        {
            Stack stack = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{' || s[i] == '[' || s[i] == '(')
                    stack.Push(s[i]);
                else
                {
                    if (stack.Count == 0)
                        return false;
                    else
                    {
                        if (s[i] == '}')
                        {
                            if (stack.Peek().Equals('{'))
                                stack.Pop();
                            else return false;
                        }
                        else if (s[i] == ']')
                        {
                            if (stack.Peek().Equals('['))
                                stack.Pop();
                            else return false;
                        }
                        else if (s[i] == ')')
                        {
                            if (stack.Peek().Equals('('))
                                stack.Pop();
                            else return false;
                        }
                    }

                }
            }
            if (stack.Count == 0)
                return true;
            else return false;
        }
    }
}
