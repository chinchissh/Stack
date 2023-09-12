using System;

namespace Stack
{
    class Program
    {
        static void Main()
        {
            Stack stack1 = new Stack(3);
            stack1.Push(4);
            stack1.Push(7);
            stack1.Push(10);
            stack1.Push(15);
            stack1.Print();
            stack1.Peek();
            Console.WriteLine($"Среднее арифметическое: {stack1.CalculateAverage()}");

            Stack stack2 = new Stack(stack1);
            stack2.Pop();
            stack2.Print();
            Console.WriteLine($"Среднее арифметическое: {stack2.CalculateAverage()}");
        }
    }
}