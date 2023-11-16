Scanner scanner = new Scanner();
scanner.GetData();

public class Scanner
{
    
    public string type = "Барабанный";
    public string company = "Xerox";
    public string max_resolution = "1920x1080";
    public bool is_color = false;
    private int price = 100;

    public void GetData()
    {
        Console.WriteLine(type);
        Console.WriteLine(company);
        Console.WriteLine(max_resolution);
        Console.WriteLine(is_color);
        Console.WriteLine(price);
    }
}
