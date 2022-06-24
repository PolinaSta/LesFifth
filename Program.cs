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
 
// Console.WriteLine($"Имя: {name, -10} Возраст: {age}"); // пробелы после
// Console.WriteLine($"Имя: {name, 15} Возраст: {age}"); // пробелы до

// _____________________________________

// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int [size];
//     for(int i = 0; i<size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }
// void ShowArray(int[] array) 
// {
//     for(int i = 0; i<array.Length; i++)
//     {
//         Console.Write(array[i] + " / ");
//     }
// }
// int [] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for(int i = 0; i<myArray.Length; i++);
// {
//     if(myArray[i] > 0)
//         sum_pos += myArray;
//     else
//         sum_neg += myArray[i];
// }

// console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

// 2. 

