namespace AlgorithmPractise.LeetCode;

public class LeetCodeQ8
{
    public int MyAtoi(string s)
    {
        bool hasSymbol = false;
        bool hasValue = false;
        var isNegative = false;
        var head = 0;
        var tail = s.Length - 1;

        // 获取头尾
        {
            for (var i = 0; i < s.Length; i++)
            {

                if (s[i] == ' ')
                {
                    if (hasSymbol)
                    {
                        return 0;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (s[i]=='0')
                {
                    head = i;
                    if (!hasSymbol)
                    {
                        isNegative = false;
                    }
                    hasValue = true;
                    break;
                }
                
                if (hasSymbol)
                {
                    if (s[i] == '+')
                    {
                        return 0;
                    }

                    if (s[i] == '-')
                    {
                        return 0;
                    }
                }
                else
                {
                    if (s[i] == '+')
                    {
                        isNegative = false;
                        hasSymbol = true;
                        continue;
                    }

                    if (s[i] == '-')
                    {
                        isNegative = true;
                        hasSymbol = true;
                        continue;
                    }
                }

                if (s[i]<'0' || s[i]>'9')
                {
                    return 0;
                }

                head = i;
                hasValue = true;
                break;
            }

            if (!hasValue)
            {
                return 0;
            }
            bool hasHead = false;
            for (var i = head; i < s.Length; i++)
            {
                if (!hasHead)
                {
                    if (s[i]=='0')
                    {
                        continue;
                    }
                    else if (s[i] <= '9' && s[i] > '0')
                    {
                        hasHead = true;
                        head = i;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            if (!hasHead)
            {
                return 0;
            }

            // Console.WriteLine($"head:{head}  tail:{tail}");
            for (int i = head; i < s.Length; i++)
            {
                if (s[i] > '9' || s[i] < '0')
                {
                    tail = i - 1;
                    break;
                }
            }
        }
        
        
        var totalLength = tail - head + 1;
        if (totalLength > 10) return isNegative ? int.MinValue : int.MaxValue;

        if (totalLength == 10)
        {
            if (s[head]  > '2') return isNegative ? int.MinValue : int.MaxValue;

            if (s[head] == '2')
            {
                var withoutFirst = GetIntValue(s, head + 1, tail);
                if (isNegative)
                {
                    if (withoutFirst > 147483648)
                        return int.MinValue;
                    return -2000000000 - withoutFirst;
                }
                if (withoutFirst > 147483647)
                    return int.MaxValue;
                return 2000000000 + withoutFirst;
            }
        }

        var result = GetIntValue(s, head, tail);

        return isNegative ? result * -1 : result;
    }

    private int GetIntValue(string s, int head, int tail)
    {
        // Console.WriteLine($"head:{head}  tail:{tail}");
        int sum = 0;
        for (int i = head; i <= tail; i++)
        {
            sum += Pow10(tail - head) * (s[head]-'0');
            head++;
        }
        return sum;
    }

    public int Pow10(int count)
    {
        if (count < 1) return 1;

        var result = 10;
        var curCount = 1;
        while (curCount < count)
        {
            result *= 10;
            curCount++;
        }

        return result;
    }
}