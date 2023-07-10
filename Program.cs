Console.Write("Введите число ");
double number = double.Parse(Console.ReadLine());
double variable = number / 2;
if (variable % 1 == 0)
{
    Console.Write($"Число { number } целое");
}
else
    Console.Write($"Число { number } не является целым");