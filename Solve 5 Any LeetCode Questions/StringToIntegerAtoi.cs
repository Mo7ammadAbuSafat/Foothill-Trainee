namespace Solve_5_Any_LeetCode_Questions
{
    internal class StringToIntegerAtoi
    {
        public static int MyAtoi(string s)
        {
            s = s.Trim();
            int indexStart = -1, indexEnd = 0;
            bool flagForStart = false;
            bool flagsign = false;
            bool signN = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    if (flagsign == true)
                        return 0;
                    if (s[i] == '-' || s[i] == '+')
                    {
                        if (s[i] == '-')
                            signN = true;
                        flagsign = true;
                    }
                    else return 0;
                }
                if (Char.IsDigit(s[i]))
                {
                    flagForStart = true;
                    indexStart = i;
                    indexEnd = 0;
                    for (int j = i; j < s.Length; j++)
                    {
                        if (Char.IsDigit(s[j]))
                        {
                            indexEnd++;
                        }
                        else break;
                    }
                }
                if (flagForStart)
                    break;
            }
            if (!flagForStart)
                return 0;

            s = s.Substring(indexStart, indexEnd);

            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] != '0')
                {
                    s = s.Substring(j);
                    break;
                }
            }
                    
            if(s.Length > 14)
                s = s.Substring(0, 14);

                long result= long.Parse(s);
            if (signN)
                result *= -1;

            return (int)Math.Clamp(result, -2147483648, 2147483647);
        }
    }
}
