// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
int[]  array;
int NumbersMoreZero=0;
int[] WriteNumbers()
{
  
System.Console.Write("сколько чисел вы хотите ввести? ");

int HowMuchNumbers = Convert.ToInt32(Console.ReadLine());

 array = new int [HowMuchNumbers];
    for(int i = 0; i <= HowMuchNumbers - 1; i++)
    {
System.Console.Write("введите число:   ");
int numbers = Convert.ToInt32(Console.ReadLine());
if (numbers > 0)
{
    NumbersMoreZero++;
}
array[i] = numbers;
}
return array;

}
void PrintArray(int[] array)
     {
foreach (var item in array) {
            Console.Write($"{item}, ");
            
            }
            
}
WriteNumbers();
PrintArray(array);
System.Console.WriteLine($" введено чисел больше нуля: {NumbersMoreZero}");
System.Console.WriteLine(" ");