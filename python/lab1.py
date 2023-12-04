class Scanner:
    def __init__(self):
        self.__type = "Барабанный"
        self.company = "Xerox"
        self.max_resolution = "1920x1080"
        self.is_color = False
        self.price = 100
    
    def GetData(self):
        print(self.__type)

print("hi")
print("привет")

scanner = Scanner()
scanner.GetData()