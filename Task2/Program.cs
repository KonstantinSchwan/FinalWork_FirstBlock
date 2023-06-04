string[] array1 = new string[5] {"1234", "213", "hello", "world", "OK"};
Console.WriteLine("Наш массив: 1234, 213, hello, world, OK");
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
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
SecondArrayWithIF(array1, array2);
Console.WriteLine("Массив с 3 и менее элементами: ");
PrintArray(array2);