Console.Write("Input the size of the square matrix (less than 5): ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] arr1 = GetMatrix(size);
int[,] arr2 = GetMatrix(size);
int[,] sum = AddMatrices(arr1, arr2);
Console.WriteLine("The first Matrix is: ");
PrintMatrix(arr1);
Console.WriteLine("The Second matrix is: ");
PrintMatrix(arr2);
Console.WriteLine("The sum of the two matrices is: ");
PrintMatrix(sum);

// Creates and returns 2D matrix from user input
int[,] GetMatrix(int n) {
    int[,] arr = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"Element ({i}, {j}): ");
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return arr;
}

// Creates and returns a matrix of the sum of the 2 provided matrices
int[,] AddMatrices(int[,] arr1, int[,] arr2)
{
    int[,] sum = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for(int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0;j < arr1.GetLength(1); j++)
        {
            sum[i, j] = arr1[i, j] + arr2[i, j];
        }
    }
    return sum;
}

// Prints a provided 2D matrix
void PrintMatrix(int[,] arr)
{
    for(int i = 0;i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++) { Console.Write($"{arr[i, j]} "); }
        Console.WriteLine();
    }
}