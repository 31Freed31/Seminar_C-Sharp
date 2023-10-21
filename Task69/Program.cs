// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int NumberDegree(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * NumberDegree(numA, numB - 1);
}

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целую степень числа А: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberB < 0)
{
    Console.WriteLine(1 / (double)NumberDegree(numberA, -numberB)) ;
}
else Console.Write($"A = {numberA} B = {numberB} -> {NumberDegree(numberA, numberB)}");