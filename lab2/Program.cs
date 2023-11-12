Scanner scanner = new Scanner("drum", "xerox", 2000);
Scanner scanner2 = new Scanner();
Console.WriteLine($"Сканнер 1: {scanner.type},{scanner.company},{scanner.max_resolution}");
Console.WriteLine($"Сканнер 2: {scanner2.type},{scanner2.company},{scanner2.max_resolution}");
Console.ReadLine();
public class Scanner
{
    public Scanner() { }
    public Scanner(string type, string company, int max_resolution)
    {
        this.type = type;
        this.company = company;
        this.max_resolution = max_resolution;
    }
    public string type;
    public string company;
    public int max_resolution;
}
