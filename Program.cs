// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16


Console.WriteLine("введите число A");
int num= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int num1 = Convert.ToInt32(Console.ReadLine());
int x = num;
for (int i = 1; i < num1; i++)
{
x= x*num;
}
Console.WriteLine(x);
// Console.WriteLine("введите число А");
// int num=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите число В");
// int num1=Convert.ToInt32(Console.ReadLine());
// double d=Math.Pow(num,num1);

// Console.WriteLine(d);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("введите число А ");
int num=int.Parse(Console.ReadLine());
int V=0;
while(num>0)
{
int num1=(num%10);
num=num/10;

V=V+num1;
}
Console.WriteLine(V);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array=new int[8];
Console.WriteLine("Введ.массив чисел: ");
for(int i=0;i<8;i++) 
{
array[i] = Convert.ToInt32(Console.ReadLine());

}
return array[i];
Console.WriteLine(array[i]);
