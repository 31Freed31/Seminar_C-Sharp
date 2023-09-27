//  Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

string Range(int num)
{
    if (num == 1) return "x > 0 , y > 0";
    if (num == 2) return "x < 0 , y > 0";
    if (num == 3) return "x < 0 , y < 0";
    if (num == 4) return "x > 0 , y < 0";
    return null ;
}

Console.WriteLine("введите четверть");
int quater = Convert.ToInt32(Console.ReadLine());


string range = Range(quater);

string result = range != null  ? $"Указанная четверть соответствует диапазону {range}"
                            : "Введены некорректные координаты";
Console.WriteLine(result);
