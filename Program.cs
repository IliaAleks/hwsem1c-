//Task #1
Console.WriteLine("Task 1");
Console.WriteLine("Введите первое число: ");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b=int.Parse(Console.ReadLine());
if (a>b) {
    Console.WriteLine($"max={a} min={b}");
} else if (a<b) {
    Console.WriteLine($"max={b} min={a}");
} else {
    Console.WriteLine($"max=min={a}");
}


// Task #2
Console.WriteLine("Task 2");
int[] mas=new int[3];
Console.WriteLine("Введите первое число:");
mas[0]=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
mas[1]=int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
mas[2]=int.Parse(Console.ReadLine());
int result=0;
 for (int i=0; i<3; i++) {
    if (result<mas[i]){
        result=mas[i];
    }
 }
 Console.WriteLine($"Максимальное число равно {result}");

// Task #3
Console.WriteLine("Task 3");
Console.WriteLine("Введите число: ");
int s=int.Parse(Console.ReadLine());
if (s%2==0) {
    Console.WriteLine($"Число {s} четное");
    } else {
        Console.WriteLine($"Число {s} нечетное");
    }

// Task 4
Console.WriteLine("Введите число для ряда нутуральных чисел: ");
int d=int.Parse(Console.ReadLine());
Console.WriteLine($"Все четные числа от 1 до {d}");
for (int i=1; i<d+1; i++) {
    if (i%2==0) {
        Console.Write($"{i}, ");
    }
}
