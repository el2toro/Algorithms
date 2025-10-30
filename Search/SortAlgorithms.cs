namespace Search;

public static class SortAlgorithms
{
    public static void Sort()
    {
        var data = new int[] { 6, 20, 41, 22, 12, 66, 78, 32, 41, 20, 18, 4, 65, 24, 56, 77, 29, 10 };


        bool swapped = true;

        while (swapped)
        {
            swapped = false;

            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[i] > data[i + 1])
                {
                    //if left element is greater than right element swap them  
                    (data[i], data[i + 1]) = (data[i + 1], data[i]);

                    swapped = true;
                }
            }
        }

        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }


    public static void SelectionSort()
    {
        var data = new int[] { 6, 20, 41, 22, 12, 66, 78, 32, 41, 20, 18, 4, 65, 24, 56, 77, 29, 10 };
    }

    public static List<int> QuickSort(List<int> array)
    {
        var pivot = array[0];

        // Base case
        if (array.Count < 2)
            return array;

        var less = array.Skip(1).Where(i => i <= pivot).ToList();
        var greater = array.Skip(1).Where(i => i > pivot).ToList();

        var sorted = new List<int>();

        sorted.AddRange(QuickSort(less));
        sorted.Add(pivot);
        sorted.AddRange(QuickSort(greater));

        return sorted;
    }
}
