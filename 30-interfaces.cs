//https://www.hackerrank.com/challenges/30-interfaces/problem?isFullScreen=true

int number = Int32.Parse(Console.ReadLine());
AdvancedArithmetic myCalculator = new Calculator();
int sum = myCalculator.divisorSum(number);
Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);

interface AdvancedArithmetic
{
    int divisorSum(int number);
}

public class Calculator : AdvancedArithmetic
{
    public int divisorSum(int number)
    {
        if (number == 0)
            return 0;

        if (number == 1)
            return 1;

        int sum = 1 + number;
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
                sum += i;
        }
        return sum;
    }
}