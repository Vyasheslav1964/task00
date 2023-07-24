// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//  0 1 2 3 4
// [1 2 3 4 5] -> [5 4 3 2 1]
PrintArray(array);
void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
ReverseArray(array);
PrintArray(array);

// Array.Reverse(array);
// PrintArray(array);


