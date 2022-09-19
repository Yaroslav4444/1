Console.Write("Введите первое число ");

int userNumberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");

int userNumberB = Convert.ToInt32(Console.ReadLine());
int max = userNumberA;
int min = userNumberB;

if (userNumberA < userNumberB)
{
    max = userNumberB; min = userNumberA;
}
Console.WriteLine($" {max} большее, {min} меньшее ");