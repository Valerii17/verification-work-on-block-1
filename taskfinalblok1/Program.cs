string [] Greatarray (int m)
{
    string[] array = new string[m];

    Console.WriteLine($"Введите {m} строк: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter {i+1} rows:  ");
        array[i] = Console.ReadLine();
    }
    return array;
}
int DeterminingNumberRows (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}

string[] Resultarray(string [] array)
{
    string[] arrayrezult = new string[DeterminingNumberRows(array)];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayrezult[index] = array[i];
            index++;
        }
    }
    return arrayrezult;
}
void ShowArray(string[] array )
{
    for(int i=0; i< array.Length; i++)
      Console.Write(array[i] +" ");
    Console.WriteLine();  
}
Console.Write("Enter the number of rows in the array ");
int row = Convert.ToInt32(Console.ReadLine());
string [] array = Greatarray(row);
Console.WriteLine("An array of rows that you entered  ");
ShowArray(array);
string [] arrayrezult = Resultarray(array);
Console.WriteLine("Rows with less than or 3 characters:  ");
ShowArray(arrayrezult);
