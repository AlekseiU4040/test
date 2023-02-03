// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Задача 8");

System.Console.Write("Введите число: ");
string? strNumber4_1 = Console.ReadLine();
int Number4_1 = Convert.ToInt32(strNumber4_1);

  if (Number4_1 <= 1)
  {
      System.Console.WriteLine("Решений нет");
      return;
  }

  else
  {
    int count = 2;

    while (count <= Number4_1)
    {
        System.Console.Write(count + ", ");
        count = count + 2;
    }
  }

System.Console.WriteLine();