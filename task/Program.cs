int size = 5;
string[] array = new string[size];
int num = 3;
Console.WriteLine($"Введите любые символы для заполнения массива с размером {size} через enter: ");
FillArray(array);
Console.Clear();
PrintArray(array);
Console.WriteLine();
PrintArray(CreateSecondArray(array));

void FillArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine();
    Console.WriteLine("[" + String.Join(", ", array) + "]");
}

int SortedArray(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length;i++)
    {
        if (array[i].Length <= num)
        {
            count++;
        }
            
    }
    return count;
}

string[] CreateSecondArray(string[] array)
{
    string[] SecondArray = new string[SortedArray(array)];

    for (int i = 0, j = 0; i < size; i++)
    {
          if (array[i].Length <= num)
          {
            SecondArray[j] = array[i];
            j++;
          }
    }
      return SecondArray;
}
