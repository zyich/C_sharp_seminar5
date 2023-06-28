/* 
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. 
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
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
 
 
void ReverseDigints (int [] array){ 
 
    for (int i = 0; i < array.Length; i++) 
    { 
        array[i]*=-1;  
    } 
    Console.WriteLine($"[{string.Join(", ", array)}]"); 
} 
 
int[] arr = CreateArray(10,-10,10); 
ReverseDigints(arr);