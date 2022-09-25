// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double b1, b2;
double k1, k2; 
System.Console.WriteLine("введите b1:  ");
b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите b2:  ");
b2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите k1:  ");
k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите k2:  ");
k2 = Convert.ToInt32(Console.ReadLine());

void TochkaPeresecheniya(double b1, double b2, double k1 ,double  k2)
{
double x = (b1 - b2 ) / (k2 - k1);
 double y = (k1 * x +b1);
if ( k1 == k2 )
{
Console.WriteLine("прямые не пересекаются");
          
}
else 
{
Console.WriteLine($"точка пересечения прямых {x}, {y}");
  }





}

TochkaPeresecheniya(b1, b2, k1, k2);