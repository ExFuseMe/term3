import random
import string
import time

class Scanner:
    def __init__(self, id, weight, type, company):
        self.ID = id
        self.Weight = weight
        self.Type = type
        self.Company = company

def StartSorting():
    return time.time()
def EndSorting(starting_time):
    print(time.time() - starting_time)
def BubbleSort(scanners, column):
    for i in range(len(scanners) - 1):
        for j in range(len(scanners) - 1 - i):
            swap = False
            if column == 1:
                swap = scanners[j].ID > scanners[j + 1].ID
            elif column == 2:
                swap = scanners[j].Weight > scanners[j + 1].Weight
            elif column == 3:
                swap = scanners[j].Type > scanners[j + 1].Type
            elif column == 4:
                swap = scanners[j].Company > scanners[j + 1].Company
            if swap:
                temp = scanners[j]
                scanners[j] = scanners[j + 1]
                scanners[j + 1] = temp


def SelectSort(scanners, column):
    for i in range(len(scanners) - 1):
        min_index = i
        for j in range(i + 1, len(scanners)):
            if column == 1:
                min_index = j if scanners[j].ID < scanners[min_index].ID else min_index
            elif column == 2:
                min_index = j if scanners[j].Weight < scanners[min_index].Weight else min_index
            elif column == 3:
                min_index = j if scanners[j].Type < scanners[min_index].Type else min_index
            elif column == 4:
                min_index = j if scanners[j].Company < scanners[min_index].Company else min_index
        if min_index != i:
            temp = scanners[i]
            scanners[i] = scanners[min_index]
            scanners[min_index] = temp


def CocktailSort(scanners, column):
    if column == 1:
        column = "ID"
    elif column == 2:
        column = "Weight"
    elif column == 3:
        column = "Type"
    else:
        column = "Company"
    left = 0
    right = len(scanners) - 1

    while left <= right:
        for i in range(left, right, 1):
            if getattr(scanners[i], column) > getattr(scanners[i+1], column):
                scanners[i], scanners[i+1] = scanners[i+1], scanners[i]
        right -= 1
        for i in range(right, left, -1):
            if getattr(scanners[i-1], column) > getattr(scanners[i], column):
                scanners[i], scanners[i - 1] = scanners[i - 1], scanners[i]
        left += 1
    return scanners


def InsertionSort(scanners, column):
    for i in range(1, len(scanners)):
        key = scanners[i]
        j = i - 1
        while j >= 0 and Compare(scanners[j], key, column) > 0:
            scanners[j + 1] = scanners[j]
            j -= 1
        scanners[j + 1] = key


def ShellSort(scanners, column):
    n = len(scanners)
    gap = n // 2
    while gap > 0:
        for i in range(gap, n):
            temp = scanners[i]
            j = i
            while j >= gap and Compare(scanners[j - gap], temp, column) > 0:
                scanners[j] = scanners[j - gap]
                j -= gap
            scanners[j] = temp
        gap //= 2


def Compare(a, b, column):
    if column == 1:
        return a.ID - b.ID
    elif column == 2:
        return a.Weight - b.Weight
    elif column == 3:
        return a.Type - b.Type
    elif column == 4:
        return a.Company - b.Company
    else:
        return 0


def Randomize():
    id = random.randint(1, 100000)
    weight = 10 / random.random()
    letters = string.ascii_letters
    type = ''.join(random.choice(letters) for i in range(10))
    company = ''.join(random.choice(letters) for i in range(10))
    scanner = Scanner(id, weight, type, company)
    return scanner


scanners = []
print("1.Автоматическое запонение\n2.Ручное")
choice = input()
print("Сколько элементов?")
scanner_count = int(input())
if choice == "1":
    for i in range(scanner_count):
        scanners.append(Randomize())
elif choice == "2":
    for i in range(scanner_count):
        print(
            f"Введите все параметры: ID, Вес, тип, компанию {i+1}ого сканера")
        id = int(input())
        weight = float(input())
        type = input()
        company = input()
        scanner = Scanner(id, weight, type, company)
        scanners.append(scanner)

for scanner in scanners:
    print(f"Id:{scanner.ID}, weight: {scanner.Weight}, type: {scanner.Type}, company: {scanner.Company}")

column = 0
while True:
    print("Выберите столбец для сортировки")
    choice = input()
    if choice == "1":
        column = 1
        break
    elif choice == "2":
        column = 2
        break
    elif choice == "3":
        column = 3
        break
    elif choice == "4":
        column = 4
        break
    else:
        print("No such column number")

while True:
    print("Выберите метод сортировки:\n1.Bubble\n2.Select\n3.Cocktail\n4.Insertion\n5.Shell\n")
    choice = input()
    starting_time = StartSorting()
    if choice == "1":
        BubbleSort(scanners, column)
        break
    elif choice == "2":
        SelectSort(scanners, column)
        break
    elif choice == "3":
        CocktailSort(scanners, column)
        break
    elif choice == "4":
        InsertionSort(scanners, column)
        break
    elif choice == "5":
        ShellSort(scanners, column)
        break
    else:
        print("No such Method")

for scanner in scanners:
    print(f"Id:{scanner.ID}, weight: {scanner.Weight}, type: {scanner.Type}, company: {scanner.Company}")
print("Время: ", end=" ")
EndSorting(starting_time)