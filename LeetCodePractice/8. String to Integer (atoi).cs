using System.Numerics;

namespace LeetCodePractice;

public class p_8_String_to_Integer_atoi_ {
    public int MyAtoi(string s)
    {
        bool pozitive = true;
        int number = 0;
        bool numbers_started = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (Char.IsNumber(s[i]))
            {
                numbers_started = true;
                if (number > (2147483647 - (s[i] - '0')) / 10)
                {
                    if (pozitive == false)
                    {
                        number = -2147483648;
                        break;
                    }
                    else
                    {
                        number = 2147483647;
                        break;
                    }
                }
                else
                {
                    number = number * 10 + (s[i] - '0');
                }
                
            }
            else
            {
                if (s[i] == '+' && !numbers_started)
                {
                    numbers_started = true;
                }
                else
                {
                    if (s[i] == '-' && !numbers_started)
                    {
                        numbers_started = true;
                        pozitive = false;
                    }
                    else
                    {
                        if (s[i] == ' ' && numbers_started)
                        {
                            break;
                        }
                        if (s[i] != ' ')
                        {
                            break;
                        }
                    }
                }
            }
        }
        return pozitive ? number : -number;
    }

    public p_8_String_to_Integer_atoi_()
    {
        Console.WriteLine(MyAtoi("2147483646"));
    }
}