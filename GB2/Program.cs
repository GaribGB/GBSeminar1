Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number!=number2)
{
    Console.Write("Максимальное число ");
    if(number>number2) 
    {    
        Console.WriteLine(number);
    }
    else
    { 
        Console.WriteLine(number2);
    }
}
else
{
        Console.WriteLine("Числа равны");
}