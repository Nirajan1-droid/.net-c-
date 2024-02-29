using System.Collections;
using System.Collections.Generic;

public class NumberList : IEnumerable<int> // implements IEnumerable 
    
{
    private readonly int[] numbers;
    public NumberList(int[] numbers)
    { //parameterized constructor having the array as parameter 
        this.numbers = numbers;
    }
    public IEnumerator<int> GetEnumerator()
    {
        foreach (int number in numbers)
        {
            yield return number;
        }

    }
    IEnumerator 
    IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        NumberList list = new NumberList(numbers);
        foreach (int number in list)
        {
            Console.WriteLine(number);
        }
    }
}
