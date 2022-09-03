// //==== Задача 37:
// // Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// // второй и предпоследний и т.д. Результат запишите в новом массиве.
// // [1 2 3 4 5] -> 5 8 3
// // [6 7 3 6] -> 36 21

// //метод создает массив из случайных чисел
// int[] massRandom(int length)
// {
//     int[] MyArr = new int[length];

//     for (int i = 0; i < length; i++)
//     {
//         MyArr[i] = new Random().Next(-9, 10);
//     }
//     Console.WriteLine(String.Join(" ", MyArr));
//     return MyArr;
// }

// Console.Write("Задайте длину массива: ");
// int count = Convert.ToInt32(Console.ReadLine());

// // Определям массив четный или нет и создаем новый / 2;

// int nouch = 0; //четный массив признак
// int Length = count / 2;
// if (count % 2 != 0)
// {
//     nouch = 1; //признак нечетный массив
//     Length += 1;
// }

// int[] MyArr = massRandom(count);
// int[] NewArr = new int[Length];

// int j = 0;
// for (; j < count -1; j++)
// {
//     NewArr[j] = MyArr[j] * MyArr[count - 1];
//     count -= 1;
// }

// if (nouch == 1)
// {
//     // добавляем нечетный элемент старого массива в новый массив
//     NewArr[j] = MyArr[j];
// }
// //else { }

// Console.WriteLine($"[{(String.Join(", ", NewArr))}]");



// //==== Задача 34:
// // Задайте массив заполненный случайными положительными трёхзначными числами.
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2


// // метод заполнения массива
// int[] massRandom(int length)
// {
//     int[] MyArr = new int[length];

//     for (int i = 0; i < length; i++)
//     {
//         MyArr[i] = new Random().Next(100, 1000);
//     }
//     Console.WriteLine(String.Join(" ", MyArr));
//     return MyArr;
// }

// // метод подсчета четных с выводом
// void evenNum(int[] mas)
// {
// int len = mas.Length;
// int count = 0;

// for(int i =0; i < len; i++)
// {
// if(mas[i] % 2  == 0)
// {
//     count++;
// }
// }

// Console.Write("количество четных чисел ="+count );
// }

// // сама программа
// Console.Write("Задайте длину массива: ");
// int index = Convert.ToInt32(Console.ReadLine());
// int[] mass = massRandom(index);
// evenNum(mass);




//==== Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// метод создания произвольного массива
// int[] massRandom()
// {

// Console.Write("Задайте длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите min число массива: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите max число массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

//     int[] array = new int[length];
//     for(int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// // подсчет суммы элементов нечет позиция
// void sumOdd(int[] Odd)
// {
//     int summ = 0;
//     for( int i = 1; i < Odd.Length; i+=2)
//     {
//         summ += Odd[i];
//     }
//     Console.Write("Сумма не чет =: "+summ);

// }

// int[] ara = massRandom();
// Console.WriteLine(String.Join(" ", ara));
// sumOdd(ara);


//====Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива. Например: [3 7 22 2 78] -> 76

double[] massRandom()
{
    Console.Write("Задайте длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите min число массива: ");
    int min = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите max число массива: ");
    int max = Convert.ToInt32(Console.ReadLine());

    double[] array = new double[length];
    int[] res = new int[length];
    for (int i = 0; i < length; i++)
    {
        res[i] = new Random().Next(min, max); //заполнение массива целым
        array[i] = Convert.ToUInt64(res[i]);  //конвертирование в double
    }

    return array;
}

// поиск max и min/ разность

void differ(double[] mas)
{
    Console.WriteLine($"[{(String.Join(" ", mas))}]");
    double differ = 0;
    int i = 0;
    double Max = mas[i];
    double Min = mas[i + 1];

    for (i = 0; i < mas.Length; i++)
    {
        if (Max < mas[i]) Max = mas[i];
        if (Min > mas[i]) Min = mas[i];
    }
    differ = Max - Min;
    Console.Write($" Max - Min =: {differ}");
}
double[] Mass = massRandom();
differ(Mass);
