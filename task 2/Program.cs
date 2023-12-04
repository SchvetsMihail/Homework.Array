// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

void ArrayFunc (){
    Console.WriteLine("введите кол-во символов массива");
    int quantity = Convert.ToInt32(Console.ReadLine());
    int[] i = new int[quantity];
    Random array = new Random();
    for (int j = 0; j<quantity; j++){
        i[j] = array.Next(1, 100);
        Console.Write($"{i[j]}"+" ");
    }
    int a = 0;
    int count = 0;
    while (a < quantity){
        if ( i[a]< 91 && i[a] > 19){
            count++;
            a++;
        }
        else{
            a++;
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine($"В отрезке [20, 90] лежат {count} чисел ");
}

ArrayFunc();
