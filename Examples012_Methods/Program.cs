/*void Method1()
{
    System.Console.WriteLine("Автор ...");
}

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string result = Method4(10, "Text");
System.Console.WriteLine(result);


for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine();
}*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}



PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


