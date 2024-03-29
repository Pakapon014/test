﻿using System;

public class PascalTriangle
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the row number of Pascal's triangle:");
        int rowNumber = int.Parse(Console.ReadLine());

        if (rowNumber < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number.");
        }
        else
        {
            for (int i = 0; i <= rowNumber; i++ )
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(CalculatePascalValue(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }

    // Function to calculate the value at a specific position in Pascal's triangle
    public static int CalculatePascalValue(int row, int col)
    {
        if (col == 0 || col == row)
        {
            return 1;
        }
        else
        {
            return CalculatePascalValue(row - 1, col - 1) + CalculatePascalValue(row - 1, col);
        }
    }
}
