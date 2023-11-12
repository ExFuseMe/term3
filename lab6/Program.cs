using System;
using System.Runtime.Serialization.Formatters.Binary;
Scanner sc = new Scanner();
//sc.CurrentChoiceSort();
sc.BubbleSort();
//sc.lst = sc.CocktailSort(sc.lst.ToArray()).ToList();
//sc.lst = sc.ShellSort(sc.lst.ToArray(), sc.lst.Count).ToList();
sc.GetData();

[Serializable]
public class Scanner
{

    public string type;
    public string company;
    public string max_resolution;
    public List<int> lst;
    public Scanner()
    {
        List<int> lst = new List<int>();

        string count = Console.ReadLine();
        while (count != "")
        {
            int data = Convert.ToInt32(count);
            lst.Add(data);
            count = Console.ReadLine();
        }
        this.lst = lst;
    }
    public void GetData()
    {
        Console.WriteLine(type);
        Console.WriteLine(company);
        Console.WriteLine(max_resolution);
        foreach (var i in lst)
        {
            Console.WriteLine(i);
        }
    }

    //прямой выбор, прямое включение, шейкерная,Шелла
    public void CurrentChoiceSort()
    {
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        for (int i = 0; i < this.lst.Count; i++)
        {
            for (int j = i; j < this.lst.Count; j++)
            {
                if (this.lst[i] >= this.lst[j])
                {
                    int extra = this.lst[i];
                    this.lst[i] = this.lst[j];
                    this.lst[j] = extra;
                }
            }
        }
        watch.Stop();
        Console.WriteLine(watch.Elapsed);
    }

    public void BubbleSort()
    {
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        int n = lst.Count;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 1; i < n; i++)
            {
                if (lst[i - 1] > lst[i])
                {
                    // Swap the elements
                    int temp = lst[i - 1];
                    lst[i - 1] = lst[i];
                    lst[i] = temp;
                    swapped = true;
                }
            }
            n--;
        } while (swapped);
        watch.Stop();
        Console.WriteLine(watch.Elapsed);
    }
    public void InsertionSort()
    {
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        for (int i = 1; i < this.lst.Count; i++)
        {
            int key = this.lst[i];
            int j = i - 1;
            while (j >= 0 && this.lst[j] > key)
            {
                this.lst[j + 1] = this.lst[j];
                j -= 1;
            }
            this.lst[j + 1] = key;
        }
        watch.Stop();
        Console.WriteLine(watch.Elapsed);

    }
    public int[] CocktailSort(int[] array)
    {
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
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
        watch.Stop();
        Console.WriteLine(watch.Elapsed);
        return array;
    }

    public int[] ShellSort(int[] lst, int array_size)
    {
        int i, j, inc, temp;
        inc = 3;
        while (inc > 0)
        {
            for (i = 0; i < array_size; i++)
            {
                j = i;
                temp = lst[i];
                while ((j >= inc) && (lst[j - inc] > temp))
                {
                    lst[j] = lst[j - inc];
                    j = j - inc;
                }
                lst[j] = temp;
            }
            if (inc / 2 != 0)
                inc = inc / 2;
            else if (inc == 1)
                inc = 0;
            else
                inc = 1;
        }
        return lst;
    }
}
