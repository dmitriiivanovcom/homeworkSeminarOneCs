// first
/*Console.WriteLine("Please, give me three-digit number.");
int num = Convert.ToInt32(Console.ReadLine());
if(num >=100 && num < 1000)
    {
    int ld = ((num % 100) / 10);
    Console.WriteLine($"last digit of {num} is {ld}");
    }
else
    Console.WriteLine("Uncorrect input!");
*/

// second example.
    //third from the end
/*Console.WriteLine("Give me integer number.");
int num = Convert.ToInt32(Console.ReadLine());
if(num >=100)
    {
    int tn = (num / 100 % 10);
    Console.WriteLine($"Third digit of {num} is {tn}");
    }
else
    Console.WriteLine("Uncorrect input!");
*/

    //third from the beginning
/*Console.WriteLine("Give me integer number.");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
if(num > 1000)
    do
        temp = temp / 10;
    while(temp > 1000);
if(temp < 1000 && num >= 100)
    {
    temp = temp % 10;
    Console.WriteLine($"Third digit if {num} is {temp}");
    }
else
    Console.WriteLine("Its too small.");
*/

// third example
/*
Console.WriteLine("give me the day of the week number.");
int day = Convert.ToInt32(Console.ReadLine());
if(day > 0 && day < 6)
    Console.WriteLine($"{day} is a weekday");
if(day > 5 && day < 8)
    Console.WriteLine($"{day} is outlet");
if(day < 1 || day > 7)
    Console.WriteLine("Wrong number!");
*/