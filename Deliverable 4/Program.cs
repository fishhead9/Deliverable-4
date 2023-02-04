/* 
 Author: Nicholas Johnston
 Date: 2/4/2023
 Comments: Deliverable made to show the first 25 numbers of the Fibonacci sequence
*/

using System;
class Program
{
    public static int Fibonacci(int nno)
    {
        int num1 = 0;
        int num2 = 1;

        for (int i = 0; i < nno; i++)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp + num2;
        }
        return num1;
    }
    public static void Main()
    {
        int n = 25;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            Console.Write("Fibonacci number: " + Fibonacci(i) + "  ");
        }
        Console.WriteLine();
    }
}