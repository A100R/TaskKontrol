string[] mass = new string[4] {"hello", "2", "world", ":-)"};
string[] array = new string[mass.Length];
void ArrayStrings(string[] mass, string[] array)
{
    int n = 0;
    for (int i = 0; i < mass.Length; i++)
    {
      if(mass[i].Length <= 3)
        {
        array[n] = mass[i];
        n++;
        }
    }
}
void PrintArray(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}
ArrayStrings(mass, array);
PrintArray(array);