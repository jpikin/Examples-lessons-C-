void FillArray(int[] collection) // принимаем в качестве аргумента массив
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10); //  заполняем массив случайными числами
        index++;
    }
}

void PrintArray(int[] col) // принимаем в качестве аргумента массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);  // печатаем элемент массива под индексом position
        position++;
    }
}

int IndexOf(int[] collection, int find) // создаем метод для поиска индекса элемента массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

Console.WriteLine("Введите длину массива");

int lenArray = Int32.Parse(Console.ReadLine());
Console.WriteLine(); // пустая строка

int[] array = new int[lenArray]; // объявляем массив по умолчанию 10 элементов.

FillArray(array); //передаем в метод наш массив, произойдет заполнение массива ранд числами
PrintArray(array); // передаем в метод наш массив, метод будет печатать элементы массива по очереди
Console.WriteLine("Введите число, которое нужно найти");
int findNum = Int32.Parse(Console.ReadLine());
Console.WriteLine(); // пустая строка

int pos = IndexOf(array, findNum);
Console.WriteLine(pos);