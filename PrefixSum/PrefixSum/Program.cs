



int[] array = { 1, 2, 3, 4 };

int[] prefixSum = new int[array.Length];
prefixSum[0] = array[0];

for (int i = 1; i < array.Length; i++)
{
    prefixSum[i] = prefixSum[i - 1] + array[i];
}


Console.WriteLine("Before Prefix");
foreach (var item in array)
{
    Console.Write(item + " ");
}

Console.WriteLine("\nAfter Prefix");
foreach (var item in prefixSum)
{
    Console.Write(item + " ");
}








