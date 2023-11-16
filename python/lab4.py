count = int(input())
scanners = []
class Scanner:
    def __init__(self, company, type, rezolution):
        self.company = company
        self.type = type
        self.rezolution = rezolution

for i in range(count):
    print(f"{i+1} Сканнер")
    company = input("Компания-производитель\n")
    type = input("Тип\n")
    rezolution = int(input("Максимальное разрешение\n"))
    scanners.append(Scanner(company, type, rezolution))

for scanner in scanners:
    print(f"{scanner.company}, {scanner.type}, {scanner.rezolution}")

