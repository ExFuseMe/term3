class Scanner:
    def __init__(self, type="None", company="None", max_resolution="None"):
        self.type = type
        self.company = company
        self.max_resolution = max_resolution

    def GetData(self):
        print(self.type)
        print(self.company)
        print(self.max_resolution)

    def Scan(self):
        print("Your document was scanned")


class DrumScanner(Scanner):
    def __init__(self, company="None", max_resolution="None"):
        super().__init__("Drum", company, max_resolution)

    def Scan(self):
        print("Your document was scanned by drum scanner")


scanner = Scanner()
ds = DrumScanner()
ds.Scan()
print(ds.type)
print(ds.company)
print(ds.max_resolution)

