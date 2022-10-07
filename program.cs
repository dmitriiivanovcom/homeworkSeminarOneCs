// first example
/*
Console.WriteLine("add number, if your number is double - use comma");
double numberOne = double.Parse(Console.ReadLine());
Console.WriteLine("add another number, if number is double - use comma too");
double numberTwo = double.Parse(Console.ReadLine());
if(numberOne > numberTwo)
    {
        Console.WriteLine("first number is bigger");
    }
if(numberOne < numberTwo)
    {
        Console.WriteLine("second number is bigger");
    }
if(numberOne == numberTwo)
    {
        Console.WriteLine("its equals");
    }
    */

//second one

/*
Console.WriteLine("What number of numbers do you want to compare? It must be integer.");
int nOn = Convert.ToInt32(Console.ReadLine()); //nOn for number of numbers
double[] numbers = new double[nOn];
int serialNumber = 0;
    do
    {
    Console.WriteLine("Please, add number to compare.");
    double temp = double.Parse(Console.ReadLine());
    numbers[serialNumber] = temp;
    serialNumber++;
    }
    while(serialNumber < nOn);
    serialNumber = 0;
    double max = numbers[serialNumber];
    do
    {
        if(max < numbers[serialNumber++])
        {
            max = numbers[serialNumber];
        }
    }
    while(serialNumber < nOn);
if (max == numbers[0]);
    {
    Console.WriteLine("its all equals");
    }
if (max > numbers[0]);
Console.Write(max);
Console.Write("  - is bigest of your numbers!");
*/

// example number 3
/*
Console.WriteLine("Plese, give me number, it must be integer.");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 != 1 )
    {
        Console.WriteLine("Its even!");
    }
else
    {
        Console.WriteLine("It isn't even");
    }
*/

// Example number four

/*
Console.WriteLine("Please, give me integer number.");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
if(Math.Abs(num) > 1)
    if(num > 0)
        do
        {
            if(current % 2 == 1);
                {
                    current ++;
                }
            if(current % 2 == 0);
                {
                    Console.WriteLine(current);
                    current++;
                }   
        }
        while(current < num);
    else
        do
        {
        if(current % 2 == 1);
            {
                current = current - 1;
            }
        if(current % 2 == 0);
            {
                Console.WriteLine(current);
                current = current - 1;
            }
        }
while(current > num);
else
Console.WriteLine("nice try, but the number is too small");
*/
