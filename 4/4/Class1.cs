using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    internal class Class1
    {
        public class Array<T> where T : IComparable
        {
            private T[] array;

            public void InputI(T value) 
            { 
             array.Add
            }


            Random rand = new Random();

            public T[] SortShell()
            {               
                // Метод Шелла для сортировки
                int n = array.Length;
                int d = n / 2;

                while (d > 1)
                {
                    for (int i = d; i < n; i++)
                    {
                        T temp = array[i];
                        int j = i;
                        while ((j >= d) && (array[j - d].CompareTo(temp) > 0))
                        {
                            array[j] = array[j - d];
                            j -= d;
                        }
                        array[j] = temp;
                    }
                    d /= 2;
                }

                return array;
            }

            public T FindRange()
            {
                // Размах массива
                T min = array.Min();
                T max = array.Max();
                return (dynamic)max - (dynamic)min;
            }
        }
    }
}
