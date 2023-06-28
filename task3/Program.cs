/* 
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
4; массив [6, 7, 19, 345, 3] -> нет 
-3; массив [6, 7, 19, 345, 3] -> да 
*/ 
 
int [] CreateArray(int size, int min, int max){ 
    int [] array = new int [size]; 
    Random rand = new Random(); 
 
    for (int i = 0; i < size; i++) 
    { 
        array [i] = rand.Next(min, max+1); 
    } 
    Console.WriteLine($"[{string.Join(", ", array)}]"); 
    return array; 
} 
 
bool SearchNumber (int number, int [] array){ 
    for (int i = 0; i < array.Length; i++) 
    { 
        if(array[i] == number){ 
            return true; 
        } 
    } 
    return false; 
} 
 
Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());
int [] arr = CreateArray(10,0,4); 
 
string answer = SearchNumber(number, arr) ? "yes" : "no"; 
 
Console.WriteLine(answer);