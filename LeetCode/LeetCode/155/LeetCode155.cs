using System;
using System.Collections.Generic;

public class LeetCode155
{
    public static void Run()
    {
        MinStack minStack = new MinStack();
        minStack.push(2147483646);
        minStack.push(2147483646);
        minStack.push(2147483647);
        Console.WriteLine(minStack.top());
        minStack.pop();
        Console.WriteLine(minStack.getMin());
        minStack.pop();
        Console.WriteLine(minStack.getMin());
        minStack.pop();
        minStack.push(2147483647);
        Console.WriteLine(minStack.top());
        Console.WriteLine(minStack.getMin());
        minStack.push(-2147483648);
        Console.WriteLine(minStack.top());
        Console.WriteLine(minStack.getMin());
        minStack.pop();
        Console.WriteLine(minStack.getMin());
    }

    public class MinStack
    {
        private static Stack<int> minStack;
        private static Stack<int> Stack;

        public MinStack()
        {
            minStack = new Stack<int>();
            Stack = new Stack<int>();
        }

        public void push(int val)
        {
            if (minStack.Count != 0 && minStack.Peek() < val)
            {

            }
            else
            {
                minStack.Push(val);
            }

            Stack.Push(val);
        }

        public void pop()
        {
            if (minStack.Count > 1 && minStack.Peek() == Stack.Peek())
            {
                minStack.Pop();
            }

            Stack.Pop();

            if (Stack.Count == 0)
            {
                minStack.Clear();
            }
        }

        public int top()
        {
            return Stack.Peek();
        }

        public int getMin()
        {
            return minStack.Peek();
        }
    }
}