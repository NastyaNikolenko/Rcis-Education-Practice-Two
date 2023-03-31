//task 1
// using System;
//
// namespace ConsoleApplication23
// {
//     internal class Program
//     {
//         public static void Main()
//         {
//             Worker olya = new Worker();
//             Worker vika = new Worker();
//             Worker serezha = new Worker();
//
//             olya.name = "Olga";
//             olya.surname = "Oleinikova";
//             olya.rate = 1000;
//             olya.days = 30;
//
//             vika.name = "Victoria";
//             vika.surname = "Pavlova";
//             vika.rate = 2000;
//             vika.days = 90;
//
//             serezha.name = "Sergey";
//             serezha.surname = "Zlobin";
//             serezha.rate = 500;
//             serezha.days = 365;
//             
//             Console.Write("Введите имя сотрудника: ");
//             string name = Console.ReadLine();
//
//             if (name == olya.name)
//             {
//                 olya.Print();
//                 olya.GetSalary();
//             }
//
//             if (name == vika.name)
//             {
//                 vika.Print();
//                 vika.GetSalary();
//             }
//
//             if (name == serezha.name)
//             {
//                 serezha.Print();
//                 serezha.GetSalary();
//             }
//         }
//     }
//
//     class Worker
//     {
//         public string name;
//         public string surname;
//         public int rate;
//         public int days;
//
//         public void GetSalary()
//         {
//             int result = rate * days;
//             Console.WriteLine($"Зарплата: {result}");
//         }
//
//         public void Print()
//         {
//             Console.WriteLine($"Имя: {name}");
//             Console.WriteLine($"Фамилия: {surname}");
//             Console.WriteLine($"Ставка за день работы: {rate}");
//             Console.WriteLine($"Количество отработанных дней: {days}");
//         }
//     }
// }



//task 2
// using System;
//
// namespace ConsoleApplication23
// {
//     internal class Program
//     {
//         public static void Main()
//         {
//             Worker olya = new Worker("Olga", "Oleinikova", 1000, 30);
//             Worker vika = new Worker("Victoria", "Pavlova", 2000, 90);
//             Worker serezha = new Worker("Sergey", "Zlobin", 500, 365);
//
//             Console.Write("Введите имя сотрудника: ");
//             string name = Console.ReadLine();
//
//             if (name == "Olga")
//             {
//                 olya.Print();
//                 olya.GetSalary();
//             }
//
//             if (name == "Victoria")
//             {
//                 vika.Print();
//                 vika.GetSalary();
//             }
//
//             if (name == "Sergey")
//             {
//                 serezha.Print();
//                 serezha.GetSalary();
//             }
//         }
//     }
//
//     class Worker
//     {
//         private string name;
//         private string surname;
//         private int rate;
//         private int days;
//
//         public string Name
//         {
//             get { return name; }
//         }
//         public string SurName
//         {
//             get { return surname; }
//         }
//
//         public int Rate
//         {
//             get { return rate; }
//         }
//
//         public int Days
//         {
//             get { return days; }
//         }
//         
//         public void GetSalary()
//         {
//             int result = rate * days;
//             Console.WriteLine($"Зарплата: {result}");
//         }
//         
//         public Worker(string name, string surname, int rate, int days)
//         {
//             this.name = name;
//             this.surname = surname;
//             this.rate = rate;
//             this.days = days;
//         }
//
//         public void Print()
//         {
//             Console.WriteLine($"Имя: {name}");
//             Console.WriteLine($"Фамилия: {surname}");
//             Console.WriteLine($"Ставка за день работы: {rate}");
//             Console.WriteLine($"Количество отработанных дней: {days}");
//         }
//     }
// }



//task 3
// using System;
//
// namespace ConsoleAplication23
// {
//     internal class Program
//     {
//         public static void Main()
//         {
//             Calculation calc = new Calculation("dnvcjhdufh");
//             Console.WriteLine(calc.GetCalculationLine(calc.CalculationLine));
//
//             calc.SetCalculationLine("sdnidvc");
//             Console.WriteLine(calc.GetCalculationLine(calc.CalculationLine));
//
//             calc.SetLastSymbolCalculationLine('c');
//             Console.WriteLine(calc.GetCalculationLine(calc.CalculationLine));
//
//             char lastSymbol = calc.GetLastSymbol(calc.CalculationLine);
//             Console.WriteLine(lastSymbol);
//
//             string line = calc.DeleteLastSymbol(calc.CalculationLine);
//             Console.WriteLine(line);
//         }
//     }
//     
//     class Calculation
//     {
//         private string calculationLine;
//
//         public string CalculationLine
//         {
//             get { return calculationLine; }
//         }
//
//         public Calculation(string calculationLine)
//         {
//             this.calculationLine = calculationLine;
//         }
//
//         public void SetCalculationLine(string line)
//         {
//             calculationLine = line;
//         }
//
//         public string GetCalculationLine(string line)
//         {
//             return line;
//         }
//
//         public void SetLastSymbolCalculationLine ( char symbol)
//         {
//             calculationLine += Convert.ToString(symbol);
//         }
//
//         public char GetLastSymbol(string line)
//         {
//             char lastSymbol = Convert.ToChar(line.Substring(line.Length - 1));
//             return lastSymbol;
//         }
//         
//         public string DeleteLastSymbol(string line)
//         {
//             line = line.Substring(0, line.Length - 1);
//             return line;
//         }
//
//     }
// }