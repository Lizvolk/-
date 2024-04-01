using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace VP_Lab5
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] array;
        private int count;

        public int Count => count;
        public int Capacity => array.Length;

        public DynamicArray()
        {
            array = new T[20]; 
            count = 0;
        }

        public DynamicArray(int capacity)
        {
            array = new T[capacity];
            count = 0;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int j = 0; j < count; j++)
            {
                result.Append(array[j] + " ");
            }

            return result.ToString();
        }

        public void Add(T element)
        {
            if (count == Capacity)
            {
                IncreaseCapacity(10); 
            }
            array[count] = element;
            count++;
        }

        public void Add(IEnumerable<T> elements)
        {
            foreach (T element in elements)
            {
                Add(element);
            }
        }

        public void Insert(T element, int position)
        {
            if (position < 0 || position > count)
            {
                throw new Exception( "Position is out of range.");
            }

            if (count == Capacity)
            {
                IncreaseCapacity(10); 
            }

            for (int i = count; i > position; i--)
            {
                array[i] = array[i - 1];
            }
            array[position] = element;
            count++;
        }

        public void RemoveAt(int position)
        {
            if (position < 0 || position >= count)
            {
                throw new Exception("Position is out of range.");
            }

            for (int i = position; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            count--;
        }

        public void IncreaseCapacity(int n)
        {
            T[] newArray = new T[Capacity + n];
            Array.Copy(array, newArray, count);
            array = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i=0; i< Count; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        private class DynamicArrayEnumerator : IEnumerator<T>
        {
            private DynamicArray<T> dynamicArray;
            private int currentIndex;

            public DynamicArrayEnumerator(DynamicArray<T> array)
            {
                dynamicArray = array;
                currentIndex = -1;
            }

            public T Current => dynamicArray.array[currentIndex];

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < dynamicArray.count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public void Dispose()
            {
            }
            public void GoToArray()
            {
                IEnumerator<T> enumerator = dynamicArray.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    T item = enumerator.Current;
                    Console.WriteLine(item);
                }
            }
        }


        public void GoToArrayForeach()
        {
            foreach(T element in array)
            {
                Console.WriteLine(element);
            }

        }

       
    }

}

//Задание 1. Нписать проход по динамическому массиву двумя способами: с помощью Enumerator и с помощью forefch. Рассказать, как эти способы связаны между собой
//Задание 2 Стандартные коллекции C#. Их свойства и отличия, когда чтто использовать.