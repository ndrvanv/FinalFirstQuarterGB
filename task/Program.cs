int size = 6;
string[] array = new string[size];

FillArray(array);
PrintArray(array);

void FillArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine();
    Console.WriteLine("[" + String.Join(" ,", array) + "]");
}