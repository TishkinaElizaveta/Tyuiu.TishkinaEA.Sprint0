﻿namespace Tyuiu.TishkinaEA.Sprint0.Task5.V1.lib
{
    public class DataService
{
    public static int Addition(int a, int b)
    { return a + b; }
    public static int Subtraction(int a, int b)
    { return a - b; }
    public static int Multiplication(int a, int b)
    { return a * b; }
    public static int double Division(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Переменная b = {0}, на ноль делить нельзя!", b);
            return -1;
        }
        else
        { return a / b; }
    }
}
}

