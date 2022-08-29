// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.

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
