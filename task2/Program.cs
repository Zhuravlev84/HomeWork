/* Напишите программу, которая на вход принимпет 3 числа  и выдает максимальное из этих чисел
2 3 7 -> 7
4 58 41 -> 58 */
Console.Write ("Ведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третие число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b & a > c & b == c || a == b & b > c)
{
    Console.Write ("max = " + a);
}
else if (b > a & b > c & a == c || b == a & a > c)
{
    Console.Write ("max = " + b);
}
else 
{
    Console.Write ("max = " + c);
}
