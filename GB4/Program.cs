Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());


if(number==number2&&number==number3)
{
    Console.WriteLine("Все числа равны");
}

else
{
    int Max = number;

    if(Max<number2)
    {
        Max=number2;
        if(Max<number3)
        {
            Max=number3;
        }
    }
    else
    {
        if(Max<number3)
        {
            Max=number3;
        }
    }

Console.Write("Максимальное число ");
Console.WriteLine(Max);
}
