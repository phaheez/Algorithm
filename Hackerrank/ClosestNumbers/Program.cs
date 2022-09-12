var numbers1 = new List<int> { 4, 2, 1, 3 };
var numbers2 = new List<int> { 6, 2, 4, 10 };

Console.WriteLine("====Test Case 1====");
ClosetNumbers(numbers1);
Console.WriteLine("====Test Case 2====");
ClosetNumbers(numbers2);

static void ClosetNumbers(List<int> numbers)
{
    var numArray = numbers.ToArray();
    var n = numArray.Length;
    if (n <= 1) return;

    Array.Sort(numArray);
    int minD = numArray[1] - numArray[0];

    for(int i = 2; i < n; i++)
        minD = Math.Min(minD, numArray[i] - numArray[i - 1]);
    for (int i = 1; i < n; i++)
    {
        if (numArray[i] - numArray[i - 1] == minD)
        {
            Console.WriteLine(numArray[i - 1] + " " + numArray[i]);
        }
    }
}