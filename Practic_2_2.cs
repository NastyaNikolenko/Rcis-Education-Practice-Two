//task 1
// using System;
//
// namespace ConsoleApplication22
// {
//     internal class Program
//     {
//         public static void Main() 
//         {
//             Student bang = new Student();
//             Student han = new Student();
//             Student lee = new Student();
//             Student kim = new Student();
//             Student hwang = new Student();
//
//             bang.surname = "Bang";
//             bang.dateOfBirth = "03.10.1997";
//             bang.numberGroup = 358;
//             bang.academicPerformance = new int[] { 5, 4, 4, 5, 4 };
//
//             han.surname = "Han";
//             han.dateOfBirth = "14.09.2000";
//             han.numberGroup = 276;
//             han.academicPerformance = new int[] { 3, 4, 4, 5, 3 };
//
//             lee.surname = "Lee";
//             lee.dateOfBirth = "25.10.1998";
//             lee.numberGroup = 168;
//             lee.academicPerformance = new int[] { 4, 5, 5, 5, 4 };
//
//             kim.surname = "Kim";
//             kim.dateOfBirth = "14.09.1994";
//             kim.numberGroup = 630;
//             kim.academicPerformance = new int[] { 5, 5, 5, 5, 5 };
//
//             hwang.surname = "Hwang";
//             hwang.dateOfBirth = "20.03.2000";
//             hwang.numberGroup = 276;
//             hwang.academicPerformance = new int[] { 3, 2, 3, 4, 4 };
//
//             Console.WriteLine("Введите фамилию студента:");
//             String entrySurname = Console.ReadLine();
//             Console.WriteLine("Введите дату рождения данного студента: ");
//             String entryDateOfBirth = Console.ReadLine();
//
//             if (entrySurname == bang.surname && entryDateOfBirth == bang.dateOfBirth)
//             {
//                 bang.Print();
//             }
//
//             if (entrySurname == han.surname && entryDateOfBirth == han.dateOfBirth)
//             {
//                 han.Print();
//             }
//
//             if (entrySurname == lee.surname && entryDateOfBirth == lee.dateOfBirth)
//             {
//                 lee.Print();
//             }
//
//             if (entrySurname == kim.surname && entryDateOfBirth == kim.dateOfBirth)
//             {
//                 kim.Print();
//             }
//
//             if (entrySurname == hwang.surname && entryDateOfBirth == hwang.dateOfBirth)
//             {
//                 hwang.Print();
//             }
//
//         }
//     }
//
//
//
//     class Student
//     {
//         public string surname;
//         public int numberGroup;
//         public string dateOfBirth;
//         public int[] academicPerformance = new int[5];
//
//         public void Print()
//         {
//             Console.WriteLine($"\nФамилия: {surname}");
//             Console.WriteLine($"Дата рождения: {dateOfBirth}");
//             Console.WriteLine($"Номер группы: {numberGroup}");
//             Console.Write($"Успеваемость:");
//             for (int i = 0; i < 5; ++i)
//             {
//                 Console.Write($" {academicPerformance[i]},");
//                 if (i == 4)
//                 {
//                     Console.Write($" {academicPerformance[i]}.");
//                 }
//             }
//         }
//     }
// }



//task 2
// using System;
//
// namespace ConsoleApplication22
// {
//     internal class Program
//     {
//         public static void Main()
//         {
//             Train firstTrain = new Train();
//             Train secondTrain = new Train();
//             Train thirdTrain = new Train();
//             Train fourthTrain = new Train();
//             Train fifthTrain = new Train();
//             Train sixthTrain = new Train();
//
//             firstTrain.trainNumber = 63731;
//             firstTrain.destinationName = "Fort Sill";
//             firstTrain.departureTime = "15:56";
//
//             secondTrain.trainNumber = 90251;
//             secondTrain.destinationName = "Centuri";
//             secondTrain.departureTime = "05:10";
//
//             thirdTrain.trainNumber = 27295;
//             thirdTrain.destinationName = "Kandava";
//             thirdTrain.departureTime = "19:05";
//
//             fourthTrain.trainNumber = 25356;
//             fourthTrain.destinationName = "Dilon";
//             fourthTrain.departureTime = "10:25";
//
//             fifthTrain.trainNumber = 31720;
//             fifthTrain.destinationName = "Canal Fulton";
//             fifthTrain.departureTime = "12:48";
//
//             sixthTrain.trainNumber = 38272;
//             sixthTrain.destinationName = "Brailov";
//             sixthTrain.departureTime = "09:11";
//
//             Console.Write("Введите номер необходимого поезда: ");
//             int num = Convert.ToInt32(Console.ReadLine());
//
//             if (num == firstTrain.trainNumber)
//             {
//                 firstTrain.Print();
//             }
//
//             if (num == secondTrain.trainNumber)
//             {
//                 secondTrain.Print();
//             }
//
//             if (num == thirdTrain.trainNumber)
//             {
//                 thirdTrain.Print();
//             }
//
//             if (num == fourthTrain.trainNumber)
//             {
//                 fourthTrain.Print();
//             }
//
//             if (num == fifthTrain.trainNumber)
//             {
//                 fifthTrain.Print();
//             }
//
//             if (num == sixthTrain.trainNumber)
//             {
//                 sixthTrain.Print();
//             }
//             else
//             {
//                 Console.WriteLine($"К сожалению, поезда с данным номером не существует :(");
//             }
//
//         }
//
//         class Train
//         {
//             public String destinationName;
//             public int trainNumber;
//             public String departureTime;
//
//             public void Print()
//             {
//                 Console.WriteLine($"Номер поезда: {trainNumber}");
//                 Console.WriteLine($"Название пункта назначения: {destinationName}");
//                 Console.WriteLine($"Время отправления: {departureTime}");
//             }
//         }
//     }
// }



//task 3
// using System;
//
//  namespace ConsoleApplication22
//  {
//      internal class Program
//      {
//          public static void Main()
//          {
//              Console.Write("Введите первое число: ");
//              int enteringFirstNum = Convert.ToInt32(Console.ReadLine());
//              Console.Write("Введите второе число: ");
//              int enteringSecondNum = Convert.ToInt32(Console.ReadLine());
//
//              Nums num = new Nums();
//              
//              num.numOne = enteringFirstNum;
//              num.numTwo = enteringSecondNum;
//              
//              num.outputOnDisplay();
//              num.sum();
//              num.highestValue();
//              
//          }
//      }
//
//      class Nums
//      {
//          public int numOne = 0;
//          public int numTwo = 0;
//
//          public void sum()
//          {
//              int sum = numOne + numTwo;
//              Console.WriteLine($"Сумма двух чисел равна: {sum}"); 
//          }
//
//          public void highestValue()
//          {
//              if (numOne > numTwo)
//              {
//                  Console.Write($"Наибольшее число: {numOne}");
//              }
//              else if (numOne < numTwo)
//              {
//                  Console.Write($"Наибольшее число: {numTwo}");
//              }
//              else
//              {
//                  Console.Write("Числа равны");
//              }
//              
//          }
//          
//          public void outputOnDisplay()
//          {
//              Console.WriteLine($"Первое число: {numOne}"); 
//              Console.WriteLine($"Второе число: {numTwo}");
//          }
//      }
//  }



//task 4
 // using System;
 //
 // namespace ConsoleApplication22
 // {
 //     internal class Program
 //     {
 //         public static void Main()
 //         {
 //             Console.Write("Введите начальное занчение счетчика: ");
 //             int counterValue = Convert.ToInt32(Console.ReadLine());
 //
 //             counter value = new counter();
 //
 //             value.i = counterValue;
 //
 //             while (value.i != 25 & value.i < 25)
 //             {
 //                 value.increasePerUnit();
 //             }
 //             Console.WriteLine($"Увеличенное значение счетчика: {value.i}");
 //
 //             while (value.i != 10)
 //             {
 //                 value.decreaseByOne();
 //             }
 //             Console.WriteLine($"Уменьшенное число счетчика: {value.i}");
 //         }
 //     }
 //     
 //     class counter
 //     {
 //         public int i = 1;
 //      
 //         public void increasePerUnit()
 //         {
 //             ++i;
 //         }
 //      
 //         public void decreaseByOne()
 //         {
 //             --i;
 //         }
 //     }
 // }



//task 5
// using System;
//
// namespace ConspleAplication22
// {
//     internal class Program
//     {
//         public static void Main()
//         {
//             Idol namjoon = new Idol();
//             Idol bangChan = new Idol("Bang Chan", "Stray Kids");
//             Idol hongjoon = new Idol("Hongjoon", "ATEEZ");
//             
//             Console.WriteLine($"Имя: {namjoon.name}   Группа: {namjoon.group}");
//             Console.WriteLine($"Имя: {bangChan.name}   Группа: {bangChan.group}");
//             Console.WriteLine($"Имя: {hongjoon.name}   Группа: {hongjoon.group}");
//             
//             namjoon.Destructor();
//             bangChan.Destructor();
//             hongjoon.Destructor();
//         }
//     }
//
//     class Idol
//     {
//         public string name;
//         public string group;
//
//         public Idol() {name = "Namjoon"; group = "BTS";}
//
//         public Idol(string name, string group)
//         {
//             this.name = name;
//             this.group = group;
//         }
//
//         public void Destructor()
//         {
//             Console.WriteLine($"{name} был удален");
//         }
//     }
// }
