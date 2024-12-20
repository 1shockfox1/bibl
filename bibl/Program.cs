using ClassLibrary1;


int n = 7; 
int m = 5; 


int[,] matrix = Class1.CreateMatrix(n, m);


(int[] maxRow, int maxSum) = Class1.MaxSumRow(matrix);

Console.WriteLine("Сгенерированная матрица:");
Class1.PrintMatrix(matrix);
Console.WriteLine("Строка с максимальной суммой элементов: " + string.Join(", ", maxRow));
Console.WriteLine("Максимальная сумма: " + maxSum);