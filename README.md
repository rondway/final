# Итоговая проверочная работа (1 блок)
## **Условия задачи**

1. Создать репозиторий на __GitHub__
2. Нарисовать блок-схему алгоритма _(можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)_
3. Снабдить репозиторий оформленным текстовым описанием решения _(файл __README.md__)_
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом _(не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)_

**Задача:**

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
```
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```
***

## **Решение**
1. Вы находитесь в созданном репозитории `Final`.

2. Блок-схема алгоритма:

![Alt text](image-1.png)

3. Вы читаете данный фаил `README.md`

4. Программа находится в ветке `master`

код: 


using System;

class Program
{
static void Main()
{
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

string[] originalArray = new string[size];

Console.WriteLine("Введите строки массива:");
for (int i = 0; i < size; i++)
{
Console.Write($"[{i + 1}] ");
originalArray[i] = Console.ReadLine();
}

string[] newArray = FilterStrings(originalArray);

Console.WriteLine("\nНовый массив строк:");
for (int i = 0; i < newArray.Length; i++)
{
Console.WriteLine($"[{i + 1}] {newArray[i]}");
}

Console.ReadLine();
}

static string[] FilterStrings(string[] inputArray)
{
int count = 0;
for (int i = 0; i < inputArray.Length; i++)
{
if (inputArray[i].Length <= 3)
{
count++;
}
}

string[] resultArray = new string[count];


int currentIndex = 0;
for (int i = 0; i < inputArray.Length; i++)
{
if (inputArray[i].Length <= 3)
{
resultArray[currentIndex] = inputArray[i];
currentIndex++;
}
}

return resultArray;
}
}