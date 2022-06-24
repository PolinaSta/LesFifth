// // 1. Пример интерполяции строк в выводе в консоль
// string name = "Имя";
// int age = 99;
// Console.WriteLine("Имя: {0}  Возраст: {1}", name, age);

// _______________________________________________________________
// int number = 23;
// string result = string.Format("{0:f}", number);

// Console.WriteLine(result);

// _________________________
// string name = "Имя";
// int age = 99;
// Console.WriteLine($"Имя: {name}  Возраст: {age}");

// _________________________________
// int x = 8;
// int y = 7;
// string result = $"{x} + {y} = {x + y}";
// Console.WriteLine(result);

// _______________________________
// string name = "Имя";
// int age = 99;

// Console.WriteLine($"Имя: {name,-10} Возраст: {age}"); // пробелы после
// Console.WriteLine($"Имя: {name,15} Возраст: {age}"); // пробелы до

// _____________________________________

// 1.Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " / ");
//     }
// }
// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++) ;
// {
//     if (myArray[i] > 0)
//         sum_pos += myArray;
//     else
//         sum_neg += myArray[i];
// }
// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

// 2.Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");

//     }
// }
// void ShowNewArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//         Console.Write(array[i] + " ");

//     }
// }
// int[] CreateArray = CreateRandomArray(4, -2, 4);
// ShowArray(CreateArray);
// ShowNewArray(CreateArray);

// 3.Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }
// int[] MyArray = CreateRandomArray(8);

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// ShowArray(MyArray);

// int ArrayCheck(int[] array)
// {
//     for (int i = 0; i < MyArray.Length; i++)
//     {
//         if (MyArray[i] == 4)
//         {
//             return 1;
//         }       
//     }
//     return 0;
// }
// if (ArrayCheck(MyArray) == 1){
//     Console.WriteLine("  4 is present");}
//     else {
//         Console.WriteLine ("   4 is absent");
//     }

    // ДОМАШНЕЕ ЗАДАНИЕ
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
if()
array[i] % 2 == 0;
else

// 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
i+2

// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double массив
max
min
max-min

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// int a = 12;
// int b = 10;

// int max = a;
// int min = b;

// if (a > max) max = a;
// if (b > max) max = b;
// if (a < min) min = a;
// if (b < min) min = b;

// Console.Write ("max = ");
// Console.WriteLine(max);

// Console.Write ("min = ");
// Console.WriteLine(min);
