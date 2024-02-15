using System;
using System.Collections.Generic;

class Fibonacci<T>
{
    public List<T> GenerateFibonacciList(int n)
    {
        List<T> fibonacciList = new List<T>();

        dynamic a = (dynamic)0;
        dynamic b = (dynamic)1;

        fibonacciList.Add(a);
        n--;

        while (n > 0)
        {
            fibonacciList.Add(b);
            dynamic temp = b;
            b = a + b;
            a = temp;
            n--;
        }

        return fibonacciList;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество чисел Фибоначчи для сгенерации: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Fibonacci<dynamic> fibonacci = new Fibonacci<dynamic>();// создаем экземпляр класса через обобщения
        List<dynamic> fibonacciList = fibonacci.GenerateFibonacciList(n);

        Console.WriteLine($"Первые {n} чисел Фибоначчи:");

        foreach (dynamic num in fibonacciList)
        {
            Console.Write(num + " ");
        }
    }
}
