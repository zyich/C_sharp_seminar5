/* 
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.  
Результат запишите в новом массиве. 
[1 2 3 4 5] -> 5 8 3 
[6 7 3 6] -> 36 21 
*/ 
 
int [] CreateArray(int size, int min, int max){ 
    int [] array = new int [size]; 
    Random rand = new Random(); 
 
    for (int i = 0; i < size; i++) 
    { 
        array [i] = rand.Next(min, max+1); 
    } 
 
    return array; 
} 
 
int [] CreateNewArray(int [] array){ 
    int size = array.Length/2; 
    if (array.Length%2 == 1){ 
        size+=1; 
    } 
    int [] newArray = new int [size]; 
    for (int i = 0, j = array.Length-1; i<=j; i++, j--) 
    { 
        if (i == j){ 
            newArray[i] = array [i]; 
            return newArray; 
        } 
            newArray[i] = array[i]*array[j];  
    } 
    return newArray; 
} 
 
int [] arr = CreateArray(5,0,10); 
Console.WriteLine($"[{string.Join(", ", arr)}]"); 
int [] newArr = CreateNewArray(arr); 
Console.WriteLine($"[{string.Join(", ", newArr)}]");