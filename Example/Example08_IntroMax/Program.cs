int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a = 3;
int b = 4;
int c = 213;

int max = Max(a, b, c);

Console.WriteLine(max);