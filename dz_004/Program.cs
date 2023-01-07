int i = 2, a;

Console.WriteLine("Введите целое число: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine($"Четные числа до {a}");
Console.WriteLine();
while (i < a)
{
    Console.Write(i);
    Console.Write(" ");
    i = i + 2;
}