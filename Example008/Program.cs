int Max (int arg1, int arg2, int arg3)
    {
        int result = arg1;
        if (arg2 > result) result = arg2;
        if (arg3 > result) result = arg3;
        return result;
    }

int a1 = 1, a2 = 2, a3 = 3,
    b1 = 4, b2 = 5, b3 = 6,
    c1 = 7, c2 = 8, c3 = 9;

int max1 = Max(a1, a2, a3),
    max2 = Max(b1, b2, b3),
    max3 = Max(c1, c2, c3);

int max = Max(max1, max2, max3);

Console.WriteLine(max);
