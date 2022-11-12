/* Напишите программу, которая на ввод принимает число (N),
 а на выходе показывает все четные числа от 1 до N
 8 -> 2, 4, 6, 8
5-> 2, 4 */

Console.Write("Введите число: ");
int Vvod = Convert.ToInt32(Console.ReadLine());
int a = 2;
while (a <= Vvod)
{
     Console.Write( a + ", ");
     a = a + 2;
}
