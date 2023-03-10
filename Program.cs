// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int [,] CalculateAverage(int [,] array)
// {
//     int temp = 0; 
//     for (int k = 0; k < array.GetLength(0); k++)
//         {
//             for (int l = 0; l < array.GetLength(1); l++)
//             {
//                 for (int i = 0; i < array.GetLength(1); i++)
//                 {
//                     for (int j = i + 1; j < array.GetLength(1); j++)
//                     {
//                         if (array[k,i] < array[k,j])
//                         {    
//                             temp = array[k,j];
//                             array[k,j] = array[k,i];
//                             array[k,i] = temp;
//                         }
//                     }
//                 }
//             }
        
//         }
//     return array;
// }
// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(myArray);
// int [,] tempArray = CalculateAverage(myArray);
// Show2DArray(tempArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void MinStringNumber (int[,] array)
// {
// int index = 0;
// int minsum = 0;
// for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum =0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum+= array[i,j];
//         }
//         if (i==0)
//         {
//             minsum = sum;
//         }
//         else if (sum<minsum)
//         {
//             minsum = sum;
//             index = i;
//         }
//     }
// Console.WriteLine($"The row with the smallest sum of elements -> {index+1} ");
// }
// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Console.WriteLine();
// Show2DArray(myArray);
// MinStringNumber(myArray);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue+1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void MultiplicationMatrix(int[,] myArray, int [,] myArray2, int[,] result)
// {
//   for (int i = 0; i < result.GetLength(0); i++)
//    {
//     for (int j = 0; j < result.GetLength(1); j++)
//      {
//       int sum = 0;
//       for (int k = 0; k < result.GetLength(1); k++)
//       {
//         sum += myArray[i,k] * myArray2[k,j];
//       }
//       result[i,j] = sum;
//     }
//    }
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// int[,] myArray2 = Create2DRandomArray(columns, rows, minValue, maxValue);

// // int[,] result = new int[4, 4];

// MultiplicationMatrix( myArray, myArray2, result);
// Console.WriteLine($"\nПроизведение этих двух матриц:");
// Show2DArray(result);
// Console.WriteLine();
// Show2DArray(myArray);
// Show2DArray(myArray2);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array3D = new int[2, 2, 2];
// FillArray(array3D);
// PrintIndex(array3D);
// void PrintIndex(int[,,] array)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// void FillArray(int[,,] array)
// {
//     int count = 10;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.WriteLine("Введите размер массива");
// int a = int.Parse(Console.ReadLine());

// int[,] z = new int[a, a];

// int k = 1;
// int i = 0;
// int j = 0;

// while (k <= a * a)
// {
//     z[i, j] = k;
//     if (i <= j + 1 && i + j < a - 1)
//         ++j;
//     else if (i < j && i + j >= a - 1)
//         ++i;
//     else if (i >= j && i + j > a - 1)
//         --j;
//     else
//         --i;
//     ++k;
// }

// PrintArray(z);

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }

