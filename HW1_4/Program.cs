// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
string result = "";
while (index <= number)
{
    if (index % 2 == 0 && index != 2)
    {
        result = result + ", " + index; 
    }
    else if (index == 2)
    {
        result = result + index; 
    }
    index++;
}

Console.Write(result);


