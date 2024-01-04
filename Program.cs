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