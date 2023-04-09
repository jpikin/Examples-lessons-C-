int[] array = {11, 21, 3, 44, 15, 6, 79, 30};

int n = array.Length; // записываем в n длину массива

int find = 6;

int index = 0;

while (index < n)
    {
        if (array[index] == find)
        {
            Console.WriteLine(index);
            break;    
        }
        index++;
    }
