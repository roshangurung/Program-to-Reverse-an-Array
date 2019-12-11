using System;
class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int a in array)/////Using foreach loop print the array values. The Array.Reverse() function is used to invert the ordering of an array’s elements using foreach loop. Print the reverse of a value of ‘array’ variable.////
        {
            Console.WriteLine(a);
        }
        Array.Reverse(array);
        Console.WriteLine("Reversed Array : ");
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
        Console.ReadLine();
    }
}
///Output:
///1
///2
///3
///4
///5
///6
///7
///8
///9
///10
///Reversed Array : 
///10
///9
///8
///7
///6
///5
///4
///3
///2
//1