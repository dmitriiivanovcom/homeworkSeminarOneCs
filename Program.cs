// exercise one
/*
int RightSide(int num)
{
    int x1 = num % 10 * 10;
    int x2 = num % 100 / 10;
    int x3 = x1 + x2;
    return x3;
}
int LeftSide(int num)
{
    int y = num / 1000;
    return y;
}
Console.WriteLine("Give me a five-digit number.");
int num = Convert.ToInt32(Console.ReadLine());
int left = LeftSide(num);
int right = RightSide(num);
if(num < 100000 && num >= 10000)
{
    if(left == right) Console.WriteLine("Its Palindrome!");
    if(left != right) Console.WriteLine("It isn't Palindrome!");
}
else
Console.WriteLine("Please, try again.");
*/


// exercise two
/*
double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double a = ((x2-x1)*(x2-x1));
    double b = ((y2-y1)*(y2-y1));
    double c = ((z2-z1)*(z2-z1));
    double d = Math.Sqrt(a+b+c);
    double result = Math.Round(d,3);
    return result;
}

Console.WriteLine("Hey, guy. wana know some distance? give me x1.");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Now give me y1.");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Last coordinate for first point. Give me z1.");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Give me x2, guy.");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Give me y2");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Its the last one, give me z2");
double z2 = Convert.ToDouble(Console.ReadLine());

double dis = Distance(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Your distance is {dis}, do not thank, guy!");
*/

//exercise three
/*
Console.WriteLine("How many cubes you want?");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 1;
int place = 0;
int[] cubes = new int[num];
do
{
    cubes[place] = temp*temp*temp;
    temp++;
    place++;
}
while(place < num);
place = 0;
Console.WriteLine("Your cubes: ");
do
{
    Console.Write($" {cubes[place]}");
    place++;
}
while(place < num);
*/