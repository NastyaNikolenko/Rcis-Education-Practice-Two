//task 1
// using System;
// using System.Linq;
//
// namespace ConsoleApplication1
// {
//     internal class Program
//     { 
//         public static void Main()
//         {
//             Console.WriteLine("Введите строку J: ");
//             String lineJ = Console.ReadLine();
//             Console.WriteLine("Введите строку S: ");
//             String lineS = Console.ReadLine();
//             
//             int numOfCharacters = lineS.Count(x => lineJ.Contains(x));
//
//            Console.WriteLine($"Количество символов из S, входящих в J, равно: {numOfCharacters}");
//
//
//         }
//     }
// }



//task 2
// using System;
// using System.Collections.Generic;
// using System.Linq;
//
// namespace ConsoleApplication1
// {
//     internal class Program
//     {
//         public static void Main()
//         {
//          int[] candidates1 = { 2, 5, 2, 1, 2 };
//          int target = 5;
//          List<List<int>> result = CombinationSum(candidates1, target);
//          Console.WriteLine(string.Join("\n", result.Select(x => $"[{string.Join(",", x)}]")));
//         }
//         
//         static List<List<int>> CombinationSum(int[] candidates, int target)
//         {
//              Array.Sort(candidates);
//              return CombinationSumHelper(candidates, target, 0);
//         }
//
//          static List<List<int>> CombinationSumHelper(int[] candidates, int target, int start)
//          {
//              List<List<int>> result = new List<List<int>>();
//              if (target == 0)
//              {
//                  result.Add(new List<int>());
//                  return result;
//              }
//              for (int i = start; i < candidates.Length && candidates[i] <= target; i++)
//              {
//                  if (i > start && candidates[i] == candidates[i - 1]) continue;
//                  foreach (List<int> combination in CombinationSumHelper(candidates, target - candidates[i], i + 1))
//                  {
//                      combination.Insert(0, candidates[i]);
//                      result.Add(combination);
//                  }
//              }
//              return result;
//          }
//     }
// }



//task 3
// using System;
// using System.Linq;
//
// namespace ConsoleApplication1
// {
//     internal class Program
//     {
//         public static void Main()
//         {
//             int[] nums = { 1, 2, 3, 4, };
//             bool result = repeatingNumbersInNums(nums);
//             Console.Write(result);
//         }
//
//         public static bool repeatingNumbersInNums(int[] nums)
//         {
//             bool result = nums.GroupBy(x => x).Any(g => g.Count() > 1);
//             return result;
//         }
//     }
// }
