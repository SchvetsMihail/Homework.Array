// // Задайте массив из вещественных чисел с ненулевой дробной частью.
// // Найдите разницу между максимальным и минимальным элементов массива.

void ArrayFunc (){
    Console.WriteLine("введите кол-во символов массива");
    int quantity = Convert.ToInt32(Console.ReadLine());
    double [] array = new double[quantity];
    for (int i = 0; i<quantity; i++){
        array[i] = new Random().NextDouble()+0.1;
        Console.Write($"{array[i]}"+" ");
    }
    int max = 0;
    int min = 0;
    int index =0;
    while(index < quantity){
        while (array[index] > array[max]){
            max = index;
        }
        index++;
    }
    Console.WriteLine(" ");
    Console.WriteLine($"Максимальное значение - {array[max]}");
    index = 0;
    while(index < quantity){
            while (array[index] < array[min]){
             min=index;
             }
             index++;
    }
    Console.WriteLine(" ");
    Console.WriteLine($"Минимальное значение - {array[min]}");
    Console.WriteLine($"Разница между минимальным {array[min]} и максимальным {array[max]} элементами массива {array[max]-array[min]} ");
}


ArrayFunc();
