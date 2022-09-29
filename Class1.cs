using System;


class Matrix {
    
    int rows, cols;
    public int[,] arr = new int[rows, cols];
    

    Console.Write("Enter count of rows: ");
        string? rows = Console.ReadLine();
    Console.Write("Enter count of columns: ");
        string? cols = Console.ReadLine();


    public int rows = arr.GetUpperBound(0) + 1;
    public int cols = arr.GetUpperBound(1) + 1;


    public void Print()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{arr[i, j]} \n");
            }
            Console.WriteLine();
        }

    }

    public int[,] new_arr = new int[cols, rows];
    public void Change()
    {
        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                new_arr[j, i] = arr[i, j];
                Console.Write($"{new_arr[i, j]} \n");
            }
            Console.WriteLine();
        }

    }
}
