//https://www.hackerrank.com/challenges/30-recursion/problem?isFullScreen=true

int number = Convert.ToInt32(Console.ReadLine().Trim());

int factorial = GetFactorial(number);

Console.WriteLine(factorial);


static int GetFactorial(int number)
{
    if (number < 2)
        return 1;

    return number * GetFactorial(number - 1);
}
