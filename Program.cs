string[] array1 = new string[5] {"hello", "333", "world", "111", "222"};
string[] array2 = new string[array1.Length];
void arraySecond(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
arraySecond(array1, array2);
PrintArray(array2);
