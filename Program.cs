string[] array = new string[]{"123", "23", "hello", "world", "res"};
string[] newArray = new string[array.Length];
int newSize = 3;
// Solution
ArrayFiltered(array, newArray);
PrintArray(newArray);

// Main Method 

void ArrayFiltered(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= newSize)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

// Created Method PrintArray

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
