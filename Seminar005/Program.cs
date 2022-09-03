//==== Задача 31:
// Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных
// элементов массива. Например, в массиве
// [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] Array()


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// //Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


//  using System;

//  class MyNewClass
//  {

//     public static  void MyTask1()
//     {
//         //         : Задайте массив из 12 элементов, заполненный
//         // случайными числами из промежутка [-9, 9]. Найдите сумму
//         // отрицательных и положительных элементов массива.
//        int [] MyArr = new int[12];
//        int SumMin =0, SumPl = 0;

//        for (int i = 0; i< MyArr.Length; i++)
//        {
//             MyArr[i]= new Random().Next(-9,10);
//             if (MyArr[i]<0)  SumMin += MyArr[i];
//             else SumPl += MyArr[i];

//        }

//        Console.WriteLine(String.Join(", ", MyArr ));
//        Console.WriteLine($"Сумма отрицательных {SumMin}");
//        Console.WriteLine($"Сумма положительных {SumPl}");

//     }

//     public static  void MyTask32()
//     {
//         // Напишите программу замена элементов
//         // массива: положительные элементы замените на
//         // соответствующие отрицательные, и наоборот.

//         int[] MyArr = new int[12];
//         for (int i=0; i< MyArr.Length; i++)
//         {
//             MyArr[i] = new Random().Next(-9,10);
//             Console.Write($" {MyArr[i]} ");
//             MyArr[i] = -MyArr[i];
//         }
//         Console.WriteLine(String.Join(" ", MyArr));


//     //    int [] MyArr = new int[12];
//     //     // Задаем массив
//     //    for (int i = 0; i< MyArr.Length; i++)
//     //    {
//     //         MyArr[i]= new Random().Next(-9,10);

//     //    }
//     //    Console.WriteLine(String.Join(", ", MyArr ));

//     //     // Меняем элементы
//     //     for (int i=0; i < MyArr.Length; i++ )
//     //     {
//     //         MyArr[i] = -MyArr[i];
//     //     }
//     //     Console.WriteLine(String.Join(", ", MyArr ));
//     }

//     public static  bool MyTask33( )
//     {
//         // Задайте массив. Напишите программу, которая
//         // определяет, присутствует ли заданное число в массиве.

//         int[] MyArr = new int[12];
//         bool numInArr=false;
//         for (int i=0; i< MyArr.Length; i++)
//         {
//             MyArr[i] = new Random().Next(-9,10);
//         }
//         Console.WriteLine(String.Join(" ", MyArr));

//         Console.WriteLine("Введите число для поиска ");
//         int num = Convert.ToInt32(Console.ReadLine());
//              for (int i=0; i< MyArr.Length; i++)
//         {
//             if (MyArr[i] == num)  numInArr = true;
//         }

//         return numInArr;
//     }
//      public static int MyTask35()
//      {
//     // Задайте одномерный массив из 123 случайных чисел.
//     // Найдите количество элементов массива, значения которых лежат в
//     // отрезке [10,99].
//     int[] MyArr = new int[123];
//     int count=0;
//     for (int i=0; i< MyArr.Length; i++)
//     {
//         MyArr[i] = new Random().Next(-900,1000);
//         if  ((MyArr[i] >= 10) && (MyArr[i] <= 99))   count++;
//     }

//     Console.WriteLine(String.Join(" ", MyArr));
//     System.Console.WriteLine(count);

//     return count;
//  }

//    public static void MyTask37()
//  {
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве

//метод создает массив из случайных чисел
int[] massRandom(int length)
{
    int[] MyArr = new int[length];

    for (int i = 0; i < length; i++)
    {
        MyArr[i] = new Random().Next(-9, 10);
    }
    Console.WriteLine(String.Join(" ", MyArr));
    return MyArr;
}

Console.WriteLine("Задайте длину массива: ");
int count = Convert.ToInt32(Console.ReadLine());

// Определям массив четный или нет и создаем новый / 2;

int nouch = 0; //четный массив
int Length = count / 2;
if (count % 2 != 0)
{
    nouch = 1; //признак нечетный массив
    Length += 1;
}

int[] MyArr = massRandom(count);
int[] NewArr = new int[Length];

int j = 0;
for (; j < count - 1; j++)
{
    NewArr[j] = MyArr[j] * MyArr[count - 1];
    count -= 1;
}

if (nouch == 1)
{
    // добавляем нечетный элемент старого массива в новый массив
    NewArr[j] = MyArr[j];
}
else { }

Console.WriteLine($"[{(String.Join(", ", NewArr))}]");


// if (count % 2 != 0)
//     NewArr[j] = MyArr[j];
// Console.WriteLine(String.Join(" ", NewArr));

//  }
// static void Main()
// {
//    // MyTask32();

//     // bool nInA=MyTask33();
//     // Console.WriteLine( nInA ? "Да" : "Нет");

//    // int count=MyTask35();

// }


//}
