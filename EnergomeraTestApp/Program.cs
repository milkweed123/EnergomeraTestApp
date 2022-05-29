using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergomeraTestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteReference();
            while (true)
            {
                var commands = Console.ReadLine().Split();
                if (commands.Length == 0)
                {
                    Console.WriteLine("Отсутствуют комманды");
                    return;
                }
                switch (commands[0])
                {
                    case CommandNames.AddItemCommand:                       
                    case CommandNames.GetItemsCommand:
                    case CommandNames.EditItemCommand:
                    case CommandNames.DeleteItemCommand:
                    default:
                        Console.WriteLine("Неверное имя команды");
                        return;
                }
            }
        }
        /// <summary>
        /// Выводит справку на экран
        /// </summary>
        public static void WriteReference()
        {

        }
        /// <summary>
        /// Определяет правильность фигурных скобок
        /// </summary>
        /// <param name="s">Строка с скобками</param>
        /// <returns></returns>
        public static bool CheckParentheses(string s)
        {
            var stack = new Stack<char>();
            foreach (var c in s)
            {
                switch (c)
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(c);
                        break;

                    case '}':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != '{') return false;
                        break;
                    case ']':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != '[') return false;
                        break;
                    case ')':
                        if (stack.Count == 0) return false;
                        if (stack.Pop() != '(') return false;
                        break;
                }
            }
            return stack.Count == 0;
        }
        /// <summary>
        /// Расставялет символы на клавиатуре в правильном порядке
        /// </summary>
        /// <param name="s1">Образец строки</param>
        /// <param name="s2">Строка с неправильными символами</param>
        public static void FixKeyboard(string s1, string s2)
        {
            if (s1 == s2)
            {
                Console.WriteLine("0");
                return;
            }
            Dictionary<char, char> valuePairs = new Dictionary<char, char>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (!valuePairs.ContainsKey(s1[i]) && !valuePairs.ContainsKey(s2[i]))
                    {
                        valuePairs.Add(s1[i], s2[i]);
                    }
                    else
                    {
                        if ((valuePairs.ContainsKey(s1[i]) && valuePairs[s1[i]] != s2[i]) || (valuePairs.ContainsKey(s2[i]) && valuePairs[s2[i]] != s1[i]))
                        {
                            Console.WriteLine("-1");
                            return;
                        }
                    }

                }
            }
            foreach (var item in valuePairs)
            {
                s2 = new string(s2.Select(x => x == item.Key ? item.Value : (x == item.Value ? item.Key : x)).ToArray());
            }
            if (s2 != s1)
            {
                Console.WriteLine("-1");
                return;
            }
            Console.WriteLine(valuePairs.Count);
            foreach (var item in valuePairs)
            {
                Console.WriteLine(item.Key.ToString() + " " + item.Value.ToString());
            }

        }
    }
}
