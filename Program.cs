// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array=new int[6];
int count=0;
for(int i=0;i<array.Length;i++)
{
   array[i]=new Random().Next(100,1000); 
   // По сути сработает не только для 3-х значных чисел
   Console.Write(array[i]+ ", ");
   // if(array[i]>100&&array[i]<1000)
   if(array[i]%2==0)
   {
         count++;
   }

   
}
 Console.WriteLine("количество четных чисел = "+count);


// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array=new int[8];
int X=0;
for(int i=0;i<array.Length;i++)
{
   array[i]=new Random().Next(0,100); 
   Console.Write(array[i]+ ", ");
   if(i%2==1) 
   {
   X=X+array[i];
   }
  
   
}
 Console.WriteLine("сумма значений стоящих в нечетных позициях = "+X);
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array={3,7,22,2,78};

int max=0;
int min=0;
for(int i=0;i<array.Length;i++)

{
    max=array[i];
    if(max<array[i]) 
    {
    max=array[i];
    }
    min=array[3];
    if(array[i]<min) 
    {
    min=array[i];
    }
 
 }

Console.WriteLine($"Разница максимального и минимального  значений= {max-min}");
