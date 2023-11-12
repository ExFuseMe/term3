Scanner scanner = new Scanner();


DrumScanner ds = new DrumScanner();
ds.Scan();
Console.WriteLine(ds.type);
Console.WriteLine(ds.weight);
public class Scanner
{

    public string type;
    public string company;
    public string max_resolution;

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

    public new string type = "Drum";
    public new int weight = 30;
    public override void Scan()
    {
        Console.WriteLine("Your document was scanned by drum scanner");
    }
}
