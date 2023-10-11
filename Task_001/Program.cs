// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//       if ( firstNumber < secondNumber)
//       Console.WriteLine("Первое число " + firstNumber + " меньше чем второе число " + secondNumber);
//       if ( firstNumber > secondNumber)
//       Console.WriteLine("Первое число " + firstNumber + " больше чем второе число " + secondNumber);
//       if ( firstNumber == secondNumber)
//       Console.WriteLine("Введены числа равные " + "'"+firstNumber+"'");
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 1;
//             secondNumber = 1;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }

// задача 2
Console.WriteLine("Введите первое число: ");
double firstScore1  = Convert.ToDouble (Console.ReadLine ());
Console.WriteLine("Введите второе число: ");
double secondScore2 = Convert.ToDouble(Console.ReadLine());




    if(firstScore1 < secondScore2)
    Console.WriteLine(firstScore1 + " Минимальное число");
    Console.WriteLine (secondScore2 + " максимальное число");