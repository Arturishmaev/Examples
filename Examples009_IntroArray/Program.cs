int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result)
    {
        result = arg2;
    }
    if (arg3 > result)
    {
        result = arg3;
    }
    return result;
}

int[] array = { 11, 21, 31, 41, 4, 61, 17, 18, 19 };
int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
    }
    index++;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
}
int array = new int[10];
System.Console.WriteLine(array);


/*void PrintArray(int[] col)
{
    int count = col.length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }



}
int array = new int[10];
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}
int pos = IndexOf(array, 4);


FillArray(array);
PrintArray(array);
