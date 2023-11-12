using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class IntSorting
    {
        public List<int> CurrentChoiceSort(int[] list)
        {
            
            
            for (int i = 0; i < list.Length; i++)
            {
                for(int j = 0; j <  list.Length; j++)
                {
                    if (list[i] < list[j])
                    {
                        int extra = list[i];
                        list[i] = list[j];
                        list[j] = extra;
                    }
                }
            }

            List<int> result = list.OfType<int>().ToList();
            return result;
        }

        public List<int> InsertionSort(int[] list)
        {
            
            
            for (int i = 1; i < list.Length; i++)
            {
                int key = list[i];
                int j = i - 1;
                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j -= 1;
                }
                list[j + 1] = key;
            }

            List<int> result = list.OfType<int>().ToList();
            return result;
        }
        public List<int> CocktailSort(int[] array)
        {
            
            
            bool isSwapped = true;
            int start = 0;
            int end = array.Length;

            while (isSwapped == true)
            {
                isSwapped = false;
                for (int i = start; i < end - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSwapped = true;
                    }
                }
                if (isSwapped == false)
                    break;

                isSwapped = false;

                end = end - 1;
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSwapped = true;
                    }
                }
                start = start + 1;
            }

            List<int> result = array.OfType<int>().ToList();
            return result;
        }

        public List<int> ShellSort(int[] list, int array_size)
        {
            
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = list[i];
                    while ((j >= inc) && (list[j - inc] > temp))
                    {
                        list[j] = list[j - inc];
                        j = j - inc;
                    }
                    list[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }

            List<int> result = list.OfType<int>().ToList();
            return result;
        }

        public List<int> BubbleSort(int[] list)
        {
            
            
            int n = list.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (list[i - 1] > list[i])
                    {
                        int temp = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);

            List<int> result = list.OfType<int>().ToList();
            return result;
        }
    }
}
