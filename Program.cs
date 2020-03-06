using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //(){}[]
            //(]
            //([))
            string str = "{[]}";
            if (ValidParenthesis(str))
                Console.WriteLine("Is Valid");
            else
                Console.WriteLine("Is not valid");
            Console.ReadKey();
        }
       
        public static bool ValidParenthesis(string str)
        {
            var stack = new Stack<char>();
            var hashMap = new Dictionary<char, char>();
            hashMap.Add(')', '(');
            hashMap.Add('}', '{');
            hashMap.Add(']', '[');

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                    stack.Push(str[i]);
                else if (hashMap.ContainsKey(str[i]))
                {
                    if (stack.Count>0 && stack.Peek() == hashMap[str[i]])
                    {
                        stack.Pop();
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;

        }
    }

}
