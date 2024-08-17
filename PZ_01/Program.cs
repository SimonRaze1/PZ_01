using System;

class Program
{
    static void Main()
    {
        double a = 1; // приводятся значение чисел из таблицы
        double c = 1;
        double b = Math.PI / 4; 
        double result1; // приводятся решения действий
        double result2;
        double result3;
        double result4;
        double result; //общее решение

        result1 = 5 * Math.Sqrt(Math.Abs(a * c * c - Math.Pow(b, 3))); // подставление чисел и математических формул через Math
        result2 = Math.Log(3) * c;
        result3 = Math.Pow(Math.E, 3 * c) + Math.Pow(c, 2);
        result4 = Math.Pow(10, -3) * Math.Sqrt(2157 * a);
        result = result1 + result2 - result3 - result4; // простое соединение результатов действий и общее решение

        Console.WriteLine("Результат: " + result);
    }
}

