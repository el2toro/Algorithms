namespace AlgorithmImplementations;

public static class Recursion
{
    //TODO: TBD
    public static int SumRecursive(int[] array, int index = 0)
    {
        // Base case: if we've gone past the last element
        if (index >= array.Length)
            return 0;

        // Recursive case: current element + sum of the rest
        return array[index] + SumRecursive(array, index + 1);

        //How It Works
        //SumRecursive([1, 2, 3], 0) = 1 + SumRecursive([1, 2, 3], 1)
        //                  = 1 + (2 + SumRecursive([1, 2, 3], 2))
        //                  = 1 + (2 + (3 + SumRecursive([1, 2, 3], 3)))
        //                  = 1 + 2 + 3 + 0
        //                  = 6
    }
}
