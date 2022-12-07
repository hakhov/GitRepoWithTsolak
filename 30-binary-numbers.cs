//https://www.hackerrank.com/challenges/30-binary-numbers/problem?isFullScreen=true

string binaryString = Convert.ToString(127, 2);

Console.WriteLine(GetMaxLength(binaryString));

static int GetMaxLength(string binaryString)
{ 
    int count = 0; //initialize count
    int result = 0; //initialize max

    foreach (var item in binaryString)
    {
        if (item == '0')
        {
            count = 0;
        }
        else
        {
            count++;
            result = Math.Max(result, count);
        }
    }

    return result;
}