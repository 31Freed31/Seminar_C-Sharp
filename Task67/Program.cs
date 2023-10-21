// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите натуральное число") ;
int number = Convert.ToInt32(Console.ReadLine()) ;

SumOfDigit(number) ;

int SumOfDigit(int num)
{
if(num == 0) return 0;
return num % 10 + SumOfDigit(num / 10); 
}

Console.Write($"{number} -> {SumOfDigit(number)}") ;