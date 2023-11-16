import pickle

class Scanner:
    def __init__(self, company, type, rezolution):
        self.company = company
        self.type = type
        self.rezolution = rezolution

def save_scanners_to_binary_file(scanners):
    with open("scanners.bin", "wb") as file:
        pickle.dump(scanners, file)

while True:
    print("1. Записать данные\n2. Получить данные")
    choice = int(input())
    scanners = []
    if choice == 1:
        print("Количество сканеров?")
        count = int(input())
        for i in range(count):
            print(f"{i + 1} Сканнер")
            print("Компания-производитель")
            company = input()
            print("Тип")
            type = input()
            print("Максимальное разрешение")
            rezolution = int(input())
            scanners.append(Scanner(company, type, rezolution))
        save_scanners_to_binary_file(scanners)
    elif choice == 2:
        try:
            with open("scanners.bin", "rb") as file:
                scanners = pickle.load(file)
                for scanner in scanners:
                    print("Company: {0}".format(scanner.company))
                    print("Type: {0}".format(scanner.type))
                    print("Maximum Resolution: {0}".format(scanner.rezolution))
                    print()
        except FileNotFoundError:
            print("File not found. Please make sure the binary file is in the same directory as the program.")
    else:
        break


