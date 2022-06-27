Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int a = 2;

while(a<=N) 
{
    Console.Write(a);

    if(a+2<=N)
    {
        Console.Write(", ");
    }
    a=a+2;
}

Console.WriteLine(" ");
