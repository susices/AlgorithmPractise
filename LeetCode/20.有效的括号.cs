using Internal;
using System.Runtime.Serialization;
using System;
/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        // 直接进行一个栈的使用
        // 遍历字符串如果是前括号则将其另一半压入栈
        // 如果是后括号则进行比较
        // 用栈顶比较如果相同则出栈，如果不同则返回 false
        // 最后栈不为空或者提前为空，则也返回 false
        if(s.Length < 2)
        {
            return false;
        }
        Stack<char> stack = new Stack<char>();
        foreach(char i in s)
        {
            if(i == '(')
            {
                stack.Push(')');
            }
            else if(i == '{')
            {
                stack.Push('}');
            }
            else if(i == '[')
            {
                stack.Push(']');
            }
            else if(stack.Count == 0 || i != stack.Pop())
            {
                return false;
            }
        }
        return stack.Count == 0;
    }
}
// @lc code=end

