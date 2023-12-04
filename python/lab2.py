class Scanner:
    def __init__(self, type=None, company=None, max_resolution=None):
        self.type = type
        self.company = company
        self.max_resolution = max_resolution
    def GetData(self):
        return f"{self.type},{self.company},{self.max_resolution}"

# scanner = Scanner("drum", "xerox", 2000)
# scanner2 = Scanner()
# print(f"Сканнер 1: "+scanner.GetData())
# print(f"Сканнер 2: "+scanner2.GetData())
scanner = Scanner()
scanner.type = input("Тип сканнера: ")
scanner.company = input("Компания-производитель: ")
scanner.max_resolution = input("Максимальное разрешение: ")
print(scanner.GetData())