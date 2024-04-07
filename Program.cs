// // // Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// // // длина которых меньше, либо равна 3 символам.

// // // Введем элементы массива    
string[] input = {"Yard", "Hello", "Dom", "f", "445"};
// string[] input = new string[3];
// Console.WriteLine("Введите строки:");
// for (int j = 0; j < input.Length; j++)
//         {
//             Console.Write($"Строка {j + 1}: ");
//             input[j] = Console.ReadLine();
//         }
// // Создадим новый массив со строками меньше или равных 3 элементам 
string[] result = new string[input.Length];
// // Введем проверку по элементам на соответсвие условиям задачм
for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)

    {
    result [i] = input [i];    
    }
    
}
foreach (string resultItem in result)
{
//    Выведем искомый результат 
    Console.WriteLine (resultItem);    
}


    
    
    

