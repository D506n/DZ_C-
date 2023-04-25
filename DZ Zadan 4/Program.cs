Console.WriteLine("Введите число:");
int NumA = Convert.ToInt32(Console.ReadLine());

//Создал массив
int[] array = new int[NumA];

//Теперь заполняю массив числами от 1 до введённого пользователем
int Step = 0; 
array[Step] = 1;
while(Step< NumA - 1) {
     Step = Step +1;
    array[Step] = array[Step] + Step + 1;
}

//вывожу чётные числа от 1 до N
Console.Write("Чётные числа: ");
Step = 1;
while(Step < NumA){
    if(array[Step] %2==0){
        Console.Write($"{array[Step]} ");
    }
    Step = Step +1;
}