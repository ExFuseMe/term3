class Scanner:
    def __init__(self):
        self.type = "Барабанный"
        self.company = "Xerox"
        self.max_resolution = "1920x1080"
        self.is_color = False
        self.price = 100

    def GetData(self):
        print(self.type,self.company,self.max_resolution,self.is_color,self.price)


scanner = Scanner()
scanner.GetData()