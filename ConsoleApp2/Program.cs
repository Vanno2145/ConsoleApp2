using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public delegate void DisplayInfo();
    public delegate double CalculateArea(double a, double b);
    public delegate bool NumberPredicate(int number);

    static void Main()
    {
        DisplayInfo displayInfo = ShowCurrentTime;
        displayInfo += ShowCurrentDate;
        displayInfo += ShowCurrentDayOfWeek;

        Console.WriteLine("Информация о текущем времени:");
        displayInfo();


        int num = 5;


        NumberPredicate pred = IsEven;
        pred += IsOdd;
        pred += IsEazy;
        pred += IsFibonacci;    
        
        Console.WriteLine($"Число: {num}");
            
        foreach (Delegate method in pred.GetInvocationList())
        {
            Console.WriteLine($"  {method.Method.Name}: {method.DynamicInvoke(num)}");
        }

        double lenth = 9, height = 5;
        CalculateArea calc = CalculateTriangleArea;
        calc += CalculateRectangleArea;

        foreach (Delegate method in calc.GetInvocationList())
        {
            Console.WriteLine($"  {method.Method.Name}: {method.DynamicInvoke(lenth, height)}");
        }
    }
    public static bool IsEven(int number) => number % 2 == 0;
 
    public static bool IsOdd(int number) => number % 2 != 0;

    public static bool IsEazy(int number)
    {
        if (number < 2) return false; 
        for (int i = 2; i * i <= number; i++) 
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    public static bool IsFibonacci(int number)
    {
        if (number < 0) return false;

        int a = 0;
        int b = 1;

        while (a <= number)
        {
            if (a == number) return true;
            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }

    public static void ShowCurrentTime()
    {
        Console.WriteLine($"Текущее время: {DateTime.Now.ToString("HH:mm:ss")}");
    }

    public static void ShowCurrentDate()
    {
        Console.WriteLine($"Текущая дата: {DateTime.Now.ToString("yyyy-MM-dd")}");
    }

    public static void ShowCurrentDayOfWeek()
    {
        Console.WriteLine($"Сегодня: {DateTime.Now.DayOfWeek}");
    }

    public static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }

    public static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }
}
