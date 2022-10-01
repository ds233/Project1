//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
//коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] col){
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count){
        if(position == count-1) Console.Write('"'+col[position]+'"');
        else Console.Write('"'+col[position]+'"'+',');
        position++;
    }
    Console.Write("]");
}

string[] array = {"Hello", "2", "world", ":-)"};
//string[] array = {"1234", "1567", "-2", "computer science"};
//string[] array = {"Russia", "Denmark", "Kazan"};

int count = array.Length;
int result_array_lenght = 0;

for(int i=0; i<count;i++)
{
    if(array[i].Length <= 3) result_array_lenght++;
}

string[] result_array = new string[result_array_lenght];
int decr = result_array_lenght;

for(int i=0; i<count;i++)
{
    if(array[i].Length <= 3)
    {
        result_array[result_array_lenght-decr]= array[i];
        decr--;
    } 
}

PrintArray(array);
Console.WriteLine();
PrintArray(result_array);