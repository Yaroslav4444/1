Console.Write("Введите первое число ");
int userNumberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int userNumberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число ");
int userNumberC = Convert.ToInt32(Console.ReadLine());
int max = userNumberA;


if (userNumberA < userNumberB)
    {
        max = userNumberB;
    }
        if (userNumberB < userNumberC)
        {
            max = userNumberC;
        }
Console.WriteLine($" {max} максимальное число");