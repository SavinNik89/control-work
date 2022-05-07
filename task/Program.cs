// Написать программу, которая из исходного массива строк сформирует массив строк длина которых меньше либо равна 3. 
// Исходный массив вводится с клавиатуры либо задается на старте программы.


string [] FillArray()
{
    Console.Write("Введите требуемое количество строк в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine()); // Считываем введенное значение, переводим в целочисленный формат
    string[] origin = new string[n]; // создание массива длиной n
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите строку №{i + 1}: ");
        origin [i] = Console.ReadLine(); //Заполняем строку
    }
    Console.WriteLine();
    Console.WriteLine("Вы ввели:");
    PrintArray (origin); // выводим созданный массив
    return origin;
}

string [] FilteringArray (string [] array)
{
    string [] result = new string [array.Length]; // создаем новый массив равный исходному
    int i = 0;
    foreach (string str in array) // проверяем длину всех элементов исходного массива
    {
        if (str.Length <= 3)
        {
            result [i] = str; // при выполнении условия записываем значение в новый массив
            i++;
        }
    }
    return result;
}

void PrintArray (string [] array) // вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.WriteLine($"{array[i]}");
    }
}




string [] origin = FillArray ();
Console.WriteLine();
string [] result = FilteringArray (origin);
Console.WriteLine("Итоговый массив: ");
PrintArray (result);

    