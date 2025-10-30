using Search;

var array = new List<int> { 6, 20, 41, 22, 12, 66, 78, 32, 41, 20, 18, 4, 65, 24, 56, 77, 29, 10 };

var result = SortAlgorithms.QuickSort(array);

foreach (var item in result)
{
    Console.WriteLine(item);
}

//SearchAlgorithms.BinarySearch("Beth");

//var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

//Recursion.Sum(array);

Console.ReadLine();