// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


//  Первый вариант
// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int numberN)
//  {
    
//   int counter = Convert.ToString(numberN).Length;
//   int advance = 0;
//   int result = 0;

//    for (int i = 0; i < counter; i++)
//   {
//      advance = numberN - numberN % 10;
//      result = result + (numberN - advance);
//     numberN = numberN / 10;
//    }
//     return result;
//  }

//  int sumNumber = SumNumber(numberN);
//  Console.WriteLine($"Сумма цифр в числе {numberN}: " + sumNumber);


//  Второй вариант
 Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = x; i > 0; i /= 10)
{ 
    sum += i % 10; 
}
Console.WriteLine($"{x} -> Сумма цифр: {sum}");
