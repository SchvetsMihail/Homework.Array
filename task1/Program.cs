// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

void ArrayFunc (){
    Console.WriteLine("введите кол-во символов массива");
    int quantity = Convert.ToInt32(Console.ReadLine());
    int[] i = new int[quantity];
    Random array = new Random();
    for (int j = 0; j<quantity; j++){
        i[j] = array.Next();
        Console.Write($"{i[j]}"+" ");
    }
    int a = 0;
    int count = 0;
    while (a < quantity){
        if ((i[a])%2==0){
            count++;
            a++;
        }
        else{
            a++;
        }
    }    
    Console.WriteLine(" ");
    Console.WriteLine($"В указанном массиве {count} четных чисел");
}

ArrayFunc();
