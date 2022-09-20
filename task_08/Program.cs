// Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
num1 = Math.Abs(num1);
int num2 = 1;

while (num1 >= num2)
{
    if ((num2 % 2) == 0)
    {
        Console.Write(num2 + ", ");
        num2++;
    }
    num2 = num2 + 1;
}

Console.WriteLine();
