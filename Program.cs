// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части,
//  если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, 
// что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//   лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("] ");
}

void SortArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    Console.Write("[ ");
    for (int i = 0; i < newArray.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
            newArray[i] = array[i];
            Console.Write(newArray[i] + " ");
        }
    }
     Console.Write("]");
    if (count == 0)
    {
        Console.WriteLine();
        Console.Write("В данном массиве нет элементов меньше или равных трем"); 
    }
}

int size = 6;
string[] array = new string[size];
Console.WriteLine("Введите элементы сомволов размером 6 через Enter :");
FillArray(array);
Console.WriteLine("Введенный пользователем массив");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Новый массив в котором элементы меньше или равны трем:");
SortArray(array);

