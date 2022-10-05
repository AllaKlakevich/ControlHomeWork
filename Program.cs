// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Определим размер массива
Console.Write("Сколько элементов масcива Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

// Заполним массив данными от пользователя
string[] array = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    array[i] = element;
}

// Определим новый массив исходя из условий

int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}

int j = 0;
string[] array2 = new string[count];
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {
        array2[j] = array[i];
        j++;
    }
}

// Определим функцию вывода массива на экран
void ShowArray(string[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write($"]");
}

// Выведем новый массив
Console.WriteLine();
ShowArray(array2);





