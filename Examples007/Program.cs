void FillArray (int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while(index < collection.Length)
    {
        collection[index] = new Random().Next(1,20);
        index++;
    }
}

void PrintArray (int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(coll[position] + ",");
        position++;
    }
}

int[] array = new int[10];

FillArray(array);

void Sorting(int[]arr)
{
    for (int i = 0; i < arr.Length ; i++)
    {
        int maxPosition = i;
        for (int j = i + 1 ; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPosition]) 
            {
                maxPosition = j ;
            }
        }
        int temp = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temp;
    }
}

PrintArray(array);
Sorting(array);
Console.WriteLine("Сортировка");
PrintArray(array);

