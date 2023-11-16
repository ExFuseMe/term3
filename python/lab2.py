class Scanner:
    def __init__(self, type=None, company=None, max_resolution=None):
        self.type = type
        self.company = company
        self.max_resolution = max_resolution

scanner = Scanner("drum", "xerox", 2000)
scanner2 = Scanner()
print(f"Сканнер 1: {scanner.type},{scanner.company},{scanner.max_resolution}")
print(f"Сканнер 2: {scanner2.type},{scanner2.company},{scanner2.max_resolution}")
