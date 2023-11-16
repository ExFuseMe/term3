using System.Runtime.Serialization.Formatters.Binary;
start: Console.WriteLine("1. Записать данные\n2. Получить данные");
int choice = Convert.ToInt32(Console.ReadLine());
List<Scanner> scanners = new List<Scanner>();
switch (choice)
{
    case 1:
        Console.WriteLine("Количество сканеров?");
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1} Сканнер");
            Console.WriteLine("Компания-производитель");
            string company = Console.ReadLine();
            Console.WriteLine("Тип");
            string type = Console.ReadLine();
            Console.WriteLine("Максимальное разрешение");
            int rezolution = Convert.ToInt32(Console.ReadLine());
            scanners.Add(new Scanner(company, type, rezolution));
        }
        SaveScannersToBinaryFile(scanners);
        break;
    case 2:
        if (!File.Exists("scanners.bin"))
        {
            Console.WriteLine("File not found. Please make sure the binary file is in the same directory as the program.");
            return;
        }

        // Read binary file
        using (Stream stream = File.Open("scanners.bin", FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            scanners = (List<Scanner>)formatter.Deserialize(stream);

            // Display scanners data
            foreach (Scanner scanner in scanners)
            {
                Console.WriteLine("Company: {0}", scanner.company);
                Console.WriteLine("Type: {0}", scanner.type);
                Console.WriteLine("Maximum Resolution: {0}", scanner.rezolution);
                Console.WriteLine();
            }
        }
        break;
}
goto start;
static void SaveScannersToBinaryFile(List<Scanner> scanners)
{
    BinaryFormatter formatter = new BinaryFormatter();
    using (FileStream fileStream = new FileStream("scanners.bin", FileMode.Create, FileAccess.Write, FileShare.None))
    {
        formatter.Serialize(fileStream, scanners);
    }
}
[Serializable]
class Scanner
{
    public Scanner(string company, string type, int rezolution)
    {
        this.company = company;
        this.type = type;
        this.rezolution = rezolution;
    }
    public string company;
    public string type;
    public int rezolution;

}