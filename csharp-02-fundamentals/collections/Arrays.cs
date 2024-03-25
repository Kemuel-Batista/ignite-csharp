namespace csharp_02_fundamentals.collections;

public class Arrays
{
    public static void ArraysExample()
    {
        int[] integers = new int[10];

        integers[0] = 1;
        integers[1] = 10;
        integers[2] = 7;

        Console.WriteLine(integers.Length);
        Console.WriteLine(integers[0]); // 1
        Console.WriteLine(integers[1]); // 10
        Console.WriteLine(integers[2]); // 7

        int[] integers2 = [1, 10, 7]; // default lenght is 3

        Console.WriteLine(integers2.Length);

        int[,] integers3 = new int[10, 10]; // 2D

        integers3[0, 0] = 1;
        integers3[0, 3] = 2;

        Console.WriteLine(integers3[0, 0]);
        Console.WriteLine(integers3[0, 1]);
    }
 }
