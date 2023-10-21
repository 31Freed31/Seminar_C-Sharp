// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число") ;
int numberM = Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine("Введите второе натуральное число") ;
int numberN = Convert.ToInt32(Console.ReadLine()) ;

if(numberM < 1 || numberN < 1 )
{
    Console.WriteLine("Некорректный ввод!");
    return ;
}

PrintSumNaturalNumbers(numberM, numberN) ;

int PrintSumNaturalNumbers(int numM, int numN)
{
    if(numM > numN) return 0 ;
    return numM + PrintSumNaturalNumbers(numM + 1, numN);
}
if(numberN > numberM)
Console.Write($"M = {numberM} N = {numberN} -> {PrintSumNaturalNumbers(numberM, numberN)}") ;
else Console.Write($"M = {numberM} N = {numberN} -> {PrintSumNaturalNumbers(numberN, numberM)}") ;

