int[] a;
a = new int[10];

int i;
i = 0;
while(i<10)
{
    a[i] = 0;
    ++i;
}


for(int j=0;j<10;++j)
{
    string s = Console.ReadLine();
    a[j]=Convert.ToInt32(s);
}

for(i=0;i<10;++i)

Console.Write(a[i] + " ");