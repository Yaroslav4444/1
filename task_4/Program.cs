Console.Write("Введите число ");
int count = Convert.ToInt32(Console.ReadLine());
int i = 1;

Console.WriteLine("Четные числа от 1 до " + count);
while (i <= count)
{
    if (i % 2 != 1)
    {
        Console.Write(i + " ");
    }
    i++;
if (count == 0 | count == 1 | count < 0)

Console.Write("Нет четных чисел");
}