class Scanner
{
    public int ID { get; set; }
    public double Weight { get; set; }
    public string Type { get; set; }
    public string Company { get; set; }

    public Scanner(int id, double weight, string type, string company)
    {
        ID = id;
        Weight = weight;
        Type = type;
        Company = company;
    }
}

class MainClass
{
    static void BubbleSort(List<Scanner> scanners, int column)
    {
        for (int i = 0; i < scanners.Count - 1; i++)
        {
            for (int j = 0; j < scanners.Count - 1 - i; j++)
            {
                bool swap = false;
                if (column == 1) swap = scanners[j].ID > scanners[j + 1].ID;
                else if (column == 2) swap = scanners[j].Weight > scanners[j + 1].Weight;
                else if (column == 3) swap = String.Compare(scanners[j].Type, scanners[j + 1].Type) > 0;
                else if (column == 4) swap = String.Compare(scanners[j].Company, scanners[j + 1].Company) > 0;

                if (swap)
                {
                    Scanner temp = scanners[j];
                    scanners[j] = scanners[j + 1];
                    scanners[j + 1] = temp;
                }
            }
        }
    }

    static void SelectSort(List<Scanner> scanners, int column)
    {
        for (int i = 0; i < scanners.Count - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < scanners.Count; j++)
            {
                if (column == 1) minIndex = scanners[j].ID < scanners[minIndex].ID ? j : minIndex;
                else if (column == 2) minIndex = scanners[j].Weight < scanners[minIndex].Weight ? j : minIndex;
                else if (column == 3) minIndex = String.Compare(scanners[j].Type, scanners[minIndex].Type) < 0 ? j : minIndex;
                else if (column == 4) minIndex = String.Compare(scanners[j].Company, scanners[minIndex].Company) < 0 ? j : minIndex;
            }

            if (minIndex != i)
            {
                Scanner temp = scanners[i];
                scanners[i] = scanners[minIndex];
                scanners[minIndex] = temp;
            }
        }
    }

    static void CocktailSort(List<Scanner> scanners, int column)
    {
        int left = 0;
        int right = scanners.Count - 1;
        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                int swap = Compare(scanners[i], scanners[i + 1], column);

                if (swap > 0)
                {
                    Scanner temp = scanners[i];
                    scanners[i] = scanners[i + 1];
                    scanners[i + 1] = temp;
                }
            }
            right--;

            for (int i = right; i > left; i--)
            {
                int swap = Compare(scanners[i], scanners[i + 1], column);

                if (swap > 0)
                {
                    Scanner temp = scanners[i];
                    scanners[i] = scanners[i - 1];
                    scanners[i - 1] = temp;
                }
            }
            left++;
        }
    }

    public static void InsertionSort(List<Scanner> scanners, int column)
    {
        for (int i = 1; i < scanners.Count; i++)
        {
            Scanner key = scanners[i];
            int j = i - 1;

            while (j >= 0 && Compare(scanners[j], key, column) > 0)
            {
                scanners[j + 1] = scanners[j];
                j = j - 1;
            }
            scanners[j + 1] = key;
        }
    }

    public static void ShellSort(List<Scanner> scanners, int column)
    {
        int n = scanners.Count;
        int gap = n / 2;

        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                Scanner temp = scanners[i];
                int j = i;

                while (j >= gap && Compare(scanners[j - gap], temp, column) > 0)
                {
                    scanners[j] = scanners[j - gap];
                    j = j - gap;
                }
                scanners[j] = temp;
            }
            gap = gap / 2;
        }
    }

    private static int Compare(Scanner a, Scanner b, int column)
    {
        if (column == 1) return a.ID.CompareTo(b.ID);
        else if (column == 2) return a.Weight.CompareTo(b.Weight);
        else if (column == 3) return string.Compare(a.Type, b.Type);
        else if (column == 4) return string.Compare(a.Company, b.Company);
        else return 0;
    }

    public static Scanner Randomize()
    {

        Random random = new Random();
        Scanner scanner = new Scanner(random.Next(1, 100000), (double)10 / random.NextDouble(), Guid.NewGuid().ToString("N"), Guid.NewGuid().ToString("N"));
        return scanner;
    }
    public static void Main(string[] args)
    {
        List<Scanner> scanners = new List<Scanner>();
        Console.WriteLine("1.Автоматическое запонение\n2.Ручное");
        string choice = Console.ReadLine();
        Console.WriteLine("Сколько элементов?");
        int scanner_count = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case "1":
                for (int i = 0; i < scanner_count; i++)
                {
                    scanners.Add(Randomize());
                }
                break;
            case "2":
                for (int i = 0; i < scanner_count; i++)
                {
                    Console.WriteLine($"Введите все параметры: ID, Вес, тип, компанию {i+1}ого сканера");
                    Scanner scanner = new Scanner(Convert.ToInt32(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                    scanners.Add(scanner);
                }
                break;
        }

        foreach (Scanner scanner in scanners)
        {
            Console.WriteLine($"Id:{scanner.ID}, weight: {scanner.Weight}, type: {scanner.Type}, company: {scanner.Company}");
        }
    Choice1: Console.WriteLine("Выберите столбец для сортировки");
        choice = Console.ReadLine();
        int column;
        switch (choice)
        {
            case "1":
                column = 1;
                break;
            case "2":
                column = 2;
                break;
            case "3":
                column = 3;
                break;
            case "4":
                column = 4;
                break;
            default:
                Console.WriteLine("No such column number");
                goto Choice1;
        }
    Choice2: Console.WriteLine("Выберите метод сортировки:\n1.Bubble\n2.Select\n3.Cocktail\n4.Insertion\n5.Shell\n");
        choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                BubbleSort(scanners, column);
                break;
            case "2":
                SelectSort(scanners, column);
                break;
            case "3":
                CocktailSort(scanners, column);

                break;
            case "4":
                InsertionSort(scanners, column);
                break;
            case "5":
                ShellSort(scanners, column);
                break;
            default:
                Console.WriteLine("No such Method");
                goto Choice1;
        }
        foreach (Scanner scanner in scanners)
        {
            Console.WriteLine($"Id:{scanner.ID}, weight: {scanner.Weight}, type: {scanner.Type}, company: {scanner.Company}");
        }
        goto Choice1;
    }
}