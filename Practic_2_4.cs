using System;
using  System.Collections.Generic;

//task in practic work 2.4
namespace Practic_2_4
{
    internal class Program
    {
        private static Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
        };
 
        public static int ConvertRomanToNum(string text)
        {
            int num = 0, previousNum = 0;
            foreach (var i in text)
            {
                if (!romanMap.ContainsKey(i))
                {
                    return 0;
                }
                var value = romanMap[i];
                num += value;
                if (previousNum != 0 && previousNum < value)
                {
                    if (previousNum == 1 && (value == 5 || value == 10)
                        || previousNum == 10 && (value == 50 || value == 100)
                        || previousNum == 100 && (value == 500 || value == 1000))
                    {
                        num -= 2 * previousNum;
                    }
                    else
                    {
                        return 0;
                    }
                }
                previousNum = value;
            }
            return num;
        }
        
        public static void Main()
        {
            Console.Write("Введите римское число:");
            string text = Console.ReadLine();
            int num = ConvertRomanToNum(text);
            Console.WriteLine($"Римская цифра {text} = {num} ");
        }
    }
}