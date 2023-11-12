using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class StringSorting
    {
        public List<string> CurrentChoiceSort(string[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length; j++)
                {
                    if (String.Compare(list[i], list[j]) < 0)
                    {
                        string extra = list[i];
                        list[i] = list[j];
                        list[j] = extra;
                    }
                }
            }
            List<string> result = list.OfType<string>().ToList();
            return result;
        }

        public List<string> InsertionSort(string[] list)
        {
           
            for (int i = 1; i < list.Length; i++)
            {
                string key = list[i];
                int j = i - 1;
                while (j >= 0 && String.Compare(list[j], key) > 0)
                {
                    list[j + 1] = list[j];
                    j -= 1;
                }
                list[j + 1] = key;
            }

            List<string> result = list.OfType<string>().ToList();
            return result;
        }
        public List<string> CocktailSort(string[] list)
        {
            bool isSwapped = true;
            int start = 0;
            int end = list.Length;

            while (isSwapped == true)
            {
                isSwapped = false;
                for (int i = start; i < end - 1; ++i)
                {
                    if (String.Compare(list[i + 1], list[i]) < 0)
                    {
                        string temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        isSwapped = true;
                    }
                }
                if (isSwapped == false)
                    break;

                isSwapped = false;

                end = end - 1;
                for (int i = end - 1; i >= start; i--)
                {
                    if (string.Compare(list[i + 1], list[i]) < 0)
                    {
                        string temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        isSwapped = true;
                    }
                }
                start = start + 1;
            }
            List<string> result = list.OfType<string>().ToList();
            return result;
        }

        public List<string> ShellSort(string[] list, int array_size)
        {
            int i, j, inc;
            string temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = list[i];
                    while ((j >= inc) && (String.Compare(list[j - inc], temp) > 0))
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
            List<string> result = list.OfType<string>().ToList();
            return result;
        }

        public List<string> BubbleSort(string[] list)
        {
            int n = list.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (String.Compare(list[i - 1], list[i]) > 0)
                    {
                        string temp = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = temp;
                        swapped = true;
                    }
                }
                n--;
            } while (swapped);
            List<string> result = list.OfType<string>().ToList();
            return result;
        }
    }
}
