int[] CreateArray(int n)
{
int[] array = new int[n];
Random arg = new Random();

for(int col = 0; col < array.Length; col++) array[col] = arg.Next(0,101);
    return array;
}

void PrintArray(int[] array)
{
    for(int col = 0; col < array.Length; col++)
    Console.Write(array[col] + " ");
}

int[] num = CreateArray(30);
PrintArray(num);

long g = 1;
for(int col = 0; col < num.Length; col++)
{
if(num[col] % 2 == 0 && num[col] % 10 != 0) g=g*num[col];
}

Console.WriteLine();
Console.WriteLine(g);