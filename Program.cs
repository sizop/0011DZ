// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.

/*
Console.WriteLine("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n) //Метод ввод массива
{
	int[,] matrix = new int[m, n];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{ matrix[i, j] = new Random().Next(11); }
	}
	return matrix;
}

void PrintArray(int[,] matrix) //Метод печать массива
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{ Console.Write(matrix[i, j] + "\t"); }
		Console.WriteLine();
	}
}

int[,] matrix = GetArray(rows, columns);
PrintArray(matrix);
int temp = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int n = 0; n < matrix.GetLength(1); n++)
	{
		for (int j = 0; j < matrix.GetLength(1) - 1; j++)
		{
			if (matrix[i, j] < matrix[i, j + 1])
			{
				temp = matrix[i, j];
				matrix[i, j] = matrix[i, j + 1];
				matrix[i, j + 1] = temp;
			}
		}
	}
}
Console.WriteLine("Result:");
PrintArray(matrix);
*/

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] GetArray(int m, int n) //Метод ввод массива
{
	int[,] matrix = new int[m, n];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{ matrix[i, j] = new Random().Next(11); }
	}
	return matrix;
}
void PrintArray(int[,] matrix) //Метод печать массива

{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{ Console.Write(matrix[i, j] + "\t"); }
		Console.WriteLine();
	}
}

int sizeArray = 5;
int[,] matrix = GetArray(sizeArray, sizeArray);
int[] matrixSumm = new int[sizeArray];
PrintArray(matrix); Console.WriteLine();


int summ = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{ summ += matrix[i, j]; }
	matrixSumm[i] = summ;
	summ = 0;
}
//for (int i = 0; i < matrixSumm.Length; i++) //Показать массив сумм
//{ Console.Write(matrixSumm[i] + "\t"); }

int temp = int.MaxValue;
for (int i = 0; i < matrixSumm.Length; i++)
{
	if (matrixSumm[i] < temp)
	{ temp = matrixSumm[i]; summ = i+1; }
}

Console.WriteLine($"Номер строки с наименьшей суммой чисел - {summ}");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая
//  будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int[,] GetArray(int m, int n) //Метод ввод массива
{
	int[,] matrix = new int[m, n];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{ matrix[i, j] = new Random().Next(11); }
	}
	return matrix;
}
void PrintArray(int[,] matrix) //Метод печать массива

{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{ Console.Write(matrix[i, j] + "\t"); }
		Console.WriteLine();
	}
}
int sizeArray = 5;
int[,] matrix1 = GetArray(sizeArray, sizeArray);
int[,] matrix2 = GetArray(sizeArray, sizeArray);
int[,] matrixResult = GetArray(sizeArray, sizeArray);

for (int i = 0; i < matrixResult.GetLength(0); i++)
{
	for (int j = 0; j < matrixResult.GetLength(1); j++)
	{ matrixResult[i, j] = matrix1[i, j] * matrix2[i, j]; }
}
Console.WriteLine("Массив 1");
PrintArray(matrix1); Console.WriteLine();

Console.WriteLine("Массив 2");
PrintArray(matrix2); Console.WriteLine();

Console.WriteLine("Результирующий массив");
PrintArray(matrixResult);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int c = 10;
int[,,] GetArray(int k, int l, int m) //Метод ввод трехмерного массива
{
	int[,,] matrix = new int[k, l, m];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			for (int n = 0; n < matrix.GetLength(2); n++)
			{
				c++; matrix[i, j, n] = (c);
			}
		}
	}
	return matrix;
}
int[,,] matrix = GetArray(3, 3, 3);

for (int i = 0; i < matrix.GetLength(0); i++) //Вывод трехмерного массива
{
	for (int j = 0; j < matrix.GetLength(1); j++)
	{
		for (int n = 0; n < matrix.GetLength(2); n++)
		{
			Console.Write((matrix[i, j, n]) + " (" + (i) + "," + (j)
			 + "," + (n) + ",)" + "\t");
		}
		Console.WriteLine();
	}
}
*/

// Задача 62. Напишите программу, которая заполнит спирально 
// массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//ЗАДАЧА НЕ РЕШЕНА!
// Нашел готовое решение для разбора кода.

int[,] GetArray(int n)
{
	var result = new int[n, n];
	for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
	{
		for (int j = padding; j < n - padding; j++)
			result[padding, j] = currentChar;
		for (int j = padding; j < n - padding; j++)
			result[n - padding - 1, j] = currentChar;
		for (int i = padding + 2; i < n - padding - 1; i++)
			result[i, padding] = currentChar;
		for (int i = padding + 1; i < n - padding - 1; i++)
			result[i, n - padding - 1] = currentChar;
		currentChar = 1 - currentChar;
		result[padding + 1, padding] = currentChar;
	}
	if (n % 2 != 0 && result[0, 0] == 1)
		result[n / 2, n / 2] = 1;
	return result;
}

void PrintArray(int[,] matrix) //Метод печать массива

{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{ Console.Write(matrix[i, j] + "\t"); }
		Console.WriteLine();
	}
}

int[,] matrix = GetArray(4);
PrintArray(matrix);