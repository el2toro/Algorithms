namespace AlgorithmImplementations;

public static class SortAlgorithms
{
    /// <summary>
    /// Sorts the elements of the specified array in ascending order using the bubble sort algorithm.
    /// </summary>
    /// <remarks>This method modifies the input array in place and also returns the same array reference.
    /// Bubble sort has O(n^2) time complexity and is not recommended for large datasets. The sort is stable and
    /// preserves the order of equal elements.</remarks>
    /// <param name="array">The array of integers to sort. The array must not be null.</param>
    /// <returns>A reference to the input array, with its elements sorted in ascending order.</returns>
    public static IList<T> BubbleSort<T>(IList<T> array) where T : IComparable<T>
    {
        bool swapped = true;

        //The swapped variable ensures the loop continues until the array is completely sorted
        while (swapped)
        {
            swapped = false;

            // Each pass moves the largest unsorted element to its correct position at the end,
            for (int i = 0; i < array.Count - 1; i++)
            {
                //it checks each pair of neighboring elements.
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    //if the left element is bigger than the right, swap them. 
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);

                    swapped = true;
                }
            }
        }
        return array;
    }

    /// <summary>
    /// Sorts the elements of the specified array in ascending order using the selection sort algorithm.
    /// </summary>
    /// <remarks>This method modifies the input array directly and does not return a new array. The sort is
    /// not stable, and the algorithm has O(n^2) time complexity, which may be inefficient for large arrays.</remarks>
    /// <param name="array">The array of integers to sort. The array is sorted in place and must not be null.</param>
    public static IList<T> SelectionSort<T>(IList<T> array) where T : IComparable<T>
    {

        for (int i = 0; i < array.Count - 1; i++)
        {
            int minIndex = i;

            // Find the index of the minimum element in the unsorted portion
            for (int j = i + 1; j < array.Count; j++)
            {
                if (array[minIndex].CompareTo(array[j]) > 0)
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first unsorted element
            (array[i], array[minIndex]) = (array[minIndex], array[i]);
        }

        return array;
    }

    /// <summary>
    /// Sorts the elements of the specified list of integers in ascending order using the quicksort algorithm.
    /// </summary>
    /// <remarks>This method does not modify the input list; instead, it returns a new sorted list. The
    /// quicksort algorithm is used, which has an average time complexity of O(n log n). If the input list is empty or
    /// contains a single element, it is returned as is.</remarks>
    /// <param name="array">The list of integers to sort. Cannot be null.</param>
    /// <returns>A new list containing the sorted elements of the input list in ascending order.</returns>
    public static IList<T> QuickSort<T>(IList<T> array) where T : IComparable<T>
    {

        // Base case
        if (array is not null && array.Count < 2)
            return array;

        var pivot = array![0];

        var less = new List<T>();
        var greater = new List<T>();

        // Single pass over the array (skip index 0)
        for (int i = 1; i < array.Count; i++)
        {
            if (array[i].CompareTo(pivot) <= 0)
            {
                less.Add(array[i]);
            }
            else
            {
                greater.Add(array[i]);
            }
        }

        // Recursively sort less and greater, then combine
        var sorted = new List<T>(array.Count); // preallocate for efficiency

        sorted.AddRange(QuickSort(less));
        sorted.Add(pivot);
        sorted.AddRange(QuickSort(greater));

        return sorted;
    }
}
