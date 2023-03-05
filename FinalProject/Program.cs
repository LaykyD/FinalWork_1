// Написать программу, которая из массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] InputToStringArray(string str){
    string[] arrstr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
	return arrstr;
}

void PrintArray(string[] arr){
    Console.Write($"Массив, состоящий из {arr.Length} элементов: [");
	for (int i = 0; i < arr.Length; i++){
        if (i == arr.Length -1)
        Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
	}
    Console.WriteLine();
}

string[] arrayToArrayOfElemLenght3(string[] array)
{
    int lenghtFinalArray = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3) lenghtFinalArray++;
    }

    string[] finalArray = new string[lenghtFinalArray];

    int index = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3){
            finalArray[index] = array[i];
            index++;
        }
    }
    return finalArray;
}

Console.WriteLine("--------------------------------------------------------------------------------------------------------- ");
Console.WriteLine("Программа, которая из массива строк формирует массив из строк, длина которых меньше либо равна 3 символа: ");
Console.WriteLine("--------------------------------------------------------------------------------------------------------- ");

Console.Write("Введите !!ЧЕРЕЗ ПРОБЕЛ!! слова для заполнения массива: ");
string? str = Console.ReadLine();
string[] array = InputToStringArray(str);
Console.WriteLine("Исходный массив:");
PrintArray(array);

string[] finalarray = arrayToArrayOfElemLenght3(array);
Console.WriteLine("Сформированный массив:");
PrintArray(finalarray);









