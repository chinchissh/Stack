using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
   class Stack
    {
        private List<int> storage;
        private int size; 

        public Stack(int maxSize)
        {
            size = maxSize;
            storage = new List<int>(maxSize);
        }

        public Stack(Stack otherStack)
        {
            size = otherStack.size;
            storage = new List<int>(otherStack.storage);
        }

        public bool IsFull()
        {
            return storage.Count >= size;
        }

        public bool IsEmpty()
        {
            return storage.Count == 0;
        }

        public void Push(int value)
        {
            if (!IsFull())
            {
                storage.Add(value);
                Console.WriteLine($"Добавлен: {value}");
            }
            else
            {
                Console.WriteLine("Стек переполнен. Невозможно добавить элемент.");
            }
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                int removedValue = storage[storage.Count - 1];
                storage.RemoveAt(storage.Count - 1);
                Console.WriteLine($"Удален: {removedValue}");
            }
            else
            {
                Console.WriteLine("Стек пуст. Невозможно удалить элемент.");
            }
        }

        public void Peek()
        {
            if (!IsEmpty())
            {
                int topValue = storage[storage.Count - 1];
                Console.WriteLine($"Верхний элемент: {topValue}");
            }
            else
            {
                Console.WriteLine("Стек пуст. Нет элементов для просмотра.");
            }
        }

        public void Print()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Элементы стека:");
                foreach (var item in storage)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Стек пуст. Нет элементов для вывода.");
            }
        }

        public double CalculateAverage()
        {
            if (!IsEmpty())
            {
                double sum = 0;
                foreach (var item in storage)
                {
                    sum += item;
                }
                return sum / storage.Count;
            }
            else
            {
                Console.WriteLine("Стек пуст. Нет элементов для вычисления среднего арифметического.");
                return 0;
            }
        }
    }

}