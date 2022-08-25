//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (number1 > number2 )
{
   max = number1;
   min = number2;
   Console.Write("Большее число = " + max + "," + "Меньшее число = " + min);
}
else if  (number1 < number2 )
{
   max = number2;
   min = number1;
   Console.Write("Большее число = " + max + "," + "Меньшее число = " + min);
}
else
{
    Console.Write("Числа равны");
}