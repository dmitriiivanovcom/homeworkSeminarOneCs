// ex uno
// субъективно - зная про существование команды Math.Pov создать цикл было бы очень просто, 
// но это было бы не так весело=)
// моя версия дает правильные ответы даже если числа отрицательные 
// код определенно избыточный, но обладает полным функционалом для int
/*
Console.WriteLine("Add number integer.");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("To what grade does the number?(its too must be integer)");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
double c = a;
if(b > 0) // if a & b is positive
{
    do
    {
        c = c * a;
        i++;
    }
    while(i < b);
}
if(b < 0) // if a is positive, but b is negative
{
    int d;
    d = Math.Abs(b);
    do
    {
        c = c * a;
        i++;
    }
    while(i < d);
    c = 1 / c;
}
if(b == 0) // if b = 0
    c = 1;

Console.WriteLine($"The number {a} in grade {b} is {c}.");
*/

// ex dos

/*
int SummOfTheNumbers(int number)
{
    int a = number; // any necessary variables
    int b = 0;
    int c = 10;
    int d = 1;
    int e = 0;
    int f = 0;
    do //arrays size
    {
        a = a / 10;
        b++; // current of numbers
    }
    while(a > 0);
    a = number;
    int[] array = new int[b];// add new array
        for(int i = 0; i < b; i++)// add remainder of the divide to array
            {  
            array[i] = a % c;
            c = c * 10;
            }
    
    do
    {
        array[e] = array[e] / d; // clean up redundant bits
        d = d * 10;
        e++;
    }
    while(e < b);
    e = 0;
    do // make what we want
    {
        f = f + array[e];
        e++;
    }
    while(e < b);
    return f;
}

Console.WriteLine("Give me integral positive number");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 0)
Console.WriteLine("Its negative!");
if(num > 0)
{ 
int result = SummOfTheNumbers(num);
Console.WriteLine($"The sum of the components of the number {num} is {result}");
}
*/

// ex tres

/*
int[] RandomArray(int size) // random array (1-9)
{
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
            array[i] = new Random().Next(1, 10);
        return array;
}
void PrintArray(int[] array) // Print array
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.WriteLine("Add random array's size, please");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enjoy your array:");
PrintArray(RandomArray(size));
*/
