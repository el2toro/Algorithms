namespace Search;

public static class Recursion
{
    public static void Sum(int[] array)
    {
        //var array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        int sum = 0;
        if (array.Length <= 0)
        {
            Console.WriteLine($"Sum result is: {sum}");
            return;
        }

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        Console.WriteLine($"Sum result is: {sum}");
    }
}
