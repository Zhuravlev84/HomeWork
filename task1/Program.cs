/* Напишите программу, которая на ввод принмает два числа и выдает, 
какое число больше, а какое меньше
a = 5, b = 10 -> max = b
a = 7, b = 2 -> max = a */

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    int max = a;
    int min = b;
    Console.Write("max = " + a);
    Console.Write(" min = " + b);
}
else if (b > a)
{
    int max = b;
    int min = a;
Console.Write("max = " + b); 
Console.Write(" min = " + a);
}
else
{
Console.Write ("Числа равны между собой");
}
