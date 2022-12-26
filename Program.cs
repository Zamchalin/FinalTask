string[] arrayinput = new string[5] {"123", "23", "hello", "world", "res"};
string[] result = new string[arrayinput.Length];
void SecondArrayWithIF(string[] arrayinput, string[] result)
{
    int count = 0;
    for (int i = 0; i < arrayinput.Length; i++)
    {
    if(arrayinput[i].Length <= 3)
        {
        result[count] = arrayinput[i];
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
Console.Clear();
SecondArrayWithIF(arrayinput, result);
PrintArray(result);