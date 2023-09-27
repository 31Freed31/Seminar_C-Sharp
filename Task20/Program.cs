// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double FindDistance(int ax, int ay, int bx, int by) 
{
    int cathet1 = ax-bx ;
    int cathet2 = ay-by ;
    double distance = Math.Sqrt((cathet1 * cathet1) + (cathet2 * cathet2)) ;
    return distance ;
}

Console.WriteLine("Введите координаты для точки A") ;
Console.Write("X: ") ;
int x1 = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Y: ") ;
int y1 = Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Введите координаты для точки B") ;
Console.Write("X: ") ;
int x2 = Convert.ToInt32(Console.ReadLine()) ;
Console.Write("Y: ") ;
int y2 = Convert.ToInt32(Console.ReadLine()) ;

double result = FindDistance(x1, y1, x2, y2) ;
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero) ;
Console.WriteLine("" + resultRound) ;
