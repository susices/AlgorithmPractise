namespace AlgorithmPractise.LeetCode;

public class LeetCodeQ7
{
    public int Reverse(int x)
    {
        if (x < 10 && x > -10) return x;
        if (x==-2147483648)
        {
            return 0;
        }

        var isNegative = x < 0;
        if (isNegative) x = -x;

        var queue = new Queue<int>();
        while (x >= 10)
        {
            var value = x % 10;
            queue.Enqueue(value);
            x = x / 10;
        }

        queue.Enqueue(x);
        while (true)
            if (queue.TryPeek(out var item))
            {
                if (item != 0) break;
                queue.Dequeue();
            }

        if (queue.Count == 10)
        {
            var firstValue = queue.Peek();
            if (firstValue > 2) return 0;

            if (firstValue == 2)
            {
                queue.Dequeue();
                var valueWithoutFirst = GetIntValue(queue);

                if (isNegative)
                {
                    if (valueWithoutFirst > 147483648) return 0;

                    return -valueWithoutFirst -2000000000;
                }
                else
                {
                    if (valueWithoutFirst > 147483647) return 0;

                    return valueWithoutFirst + 2000000000;
                }
            }

            return GetIntValue(queue) * (isNegative ? -1 : 1);
        }

        return GetIntValue(queue) * (isNegative ? -1 : 1);
    }

    public int GetIntValue(Queue<int> queue)
    {
        var value = 0;
        while (queue.Count != 0)
        {
            var firstValue = queue.Dequeue();
            if (firstValue == 0) continue;
            value += Pow10(queue.Count) * firstValue;
        }

        return value;
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