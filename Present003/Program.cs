int Min(int a, int b, int c)
{
    int min = a;
    if (b<min) min = b;
    if (c<min) min = c;

    return(min);
    
    
}


Console.WriteLine(Min(20,5,13));