Scanner scanner = new Scanner();


DrumScanner ds = new DrumScanner();
ds.Scan();
Console.WriteLine(ds.type);
Console.WriteLine(ds.company);
Console.WriteLine(ds.max_resolution);
public class Scanner
{
    public string type = "None";
    public string company = "None";
    public string max_resolution = "None";
    public Scanner() { }
    public Scanner(string type, string company, string max_resolution)
    {
        this.type = type;
        this.company = company;
        this.max_resolution = max_resolution;
    }



    public void GetData()
    {
        Console.WriteLine(type);
        Console.WriteLine(company);
        Console.WriteLine(max_resolution);
    }
    public virtual void Scan()
    {
        Console.WriteLine("Your document was scanned");
    }
}

public class DrumScanner: Scanner
{
    public DrumScanner() { }
    public string type = "Drum";
    public string company = "None";
    public string max_resolution = "None";
    public DrumScanner(string company, string max_resolution)
    { 
        this.company = company;
        this.max_resolution = max_resolution;
    }
    public override void Scan()
    {
        Console.WriteLine("Your document was scanned by drum scanner");
    }
}
