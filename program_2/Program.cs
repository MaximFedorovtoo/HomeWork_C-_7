// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void FindNumber(int[,] array, int number)
{
    
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        if(array[i,j] == number){result = number;break;}
                }
    }
    if(result == number){Console.WriteLine($"{result} -> такое число есть массиве");}
    else{Console.WriteLine($"{number} -> такого числа в массиве нет");}
}
int EnterNumber(string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int number = EnterNumber("Ведите число которое хотите найти: ");
int [,] array = {{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4}};
FindNumber(array,number);

