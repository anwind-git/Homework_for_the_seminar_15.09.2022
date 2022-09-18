// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;
int start = 3;

while (start > 0)

      if (max < num1)
      {
        max = num1;
        start = start - 1;
      }
      else if (max < num2)
      {
        max = num2;
        start = start - 1;
      }
      else if (max < num3)
      {
        max = num3;
        start = start - 1;
      }
      else 
      {
        start = start - 1;
      }

Console.WriteLine("Из трех введенных чисел, максимальное: " + max);