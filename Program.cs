// Задача 2
/*
Console.Write("Введите первое число A - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b - ");
int b = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.WriteLine("Число A больше числа B");
}

else if(a<b)
{
    Console.WriteLine("Число B больше числа A");
} */


/*
// Задача 4
Console.Write("Введите первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число - ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max) max = b;
if(c > max) max = c;
Console.Write($"Максимальное число - {max}"); */

Console.Write("Введите число - ");
int a = Convert.ToInt32(Console.Read());
if (a % 2 == 0) Console.Write("Четное");
else Console.WriteLine("Нечетное");
// на счет этой задачи есть сомнения, у меня числа 12 и 14 нечетные получаются
// с 8 задачей у меня проблемы, я не понял пока что как ее сделать 