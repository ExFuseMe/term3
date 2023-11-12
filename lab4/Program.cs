int count = Convert.ToInt32(Console.ReadLine());
List<Scanner> scanners = new List<Scanner>();
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{i+1} Сканнер");
    Console.WriteLine("Компания-производитель");
    string company = Console.ReadLine();
    Console.WriteLine("Тип");
    string type = Console.ReadLine();
    Console.WriteLine("Максимальное разрешение");
    int rezolution = Convert.ToInt32(Console.ReadLine());
    scanners.Add(new Scanner(company, type, rezolution));
}
foreach (Scanner scanner in scanners)
{
    Console.WriteLine($"{scanner.company}, {scanner.type}, {scanner.rezolution}");
}

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