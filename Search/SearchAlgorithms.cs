namespace Search;

public static class SearchAlgorithms
{
    //Binary search works only with sorted lists
    public static void BinarySearch(string element)
    {
        var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        var names = new List<string>
        {
            "Aaron","Abigail","Ada","Adam","Aiden","Aisha","Alan","Albert","Alejandro","Alexandra",
            "Alice","Alicia","Allison","Alyssa","Amanda","Amber","Amelia","Amir","Amy","Andrea",
            "Andrew","Angela","Angelica","Anita","Ann","Anna","Anthony","Antonio","April","Ariana",
            "Ariel","Ashley","Ashton","Aubrey","Austin","Ava",
            "Barbara","Beatrice","Benjamin","Bianca","Blake","Brenda","Brian","Brianna","Brittany","Bryan",
            "Caleb","Camila","Cara","Carlos","Carmen","Carol","Caroline","Catherine","Charles","Charlotte",
            "Daniel","Daniela","David","Dean","Deirdre","Dennis","Diana","Dominic",
            "Easton","Eden","Edward","Elena","Eli","Elijah","Elizabeth","Ella",
            "Felix","Fiona","Frances","Francisco",
            "Gabriel","Gabriela","Gareth","Gavin","George","Giulia",
            "Hannah","Harold","Hector","Henry","Holly","Hope",
            "Ian","Ibrahim","Igor","Isabella",
            "Jack","Jacob","Jade","James","Jasmine","Jason","Javier","Jayden","Jenna","Jessica",
            "Kai","Karen","Karl","Katherine","Kevin","Kimberly",
            "Laura","Lauren","Leah","Leo","Leonardo","Liam",
            "Madeline","Manuel","Marco","Maria","Mariana","Mark","Martin","Maya",
            "Nathan","Natalia","Nicolas",
            "Oliver","Olivia",
        };

        int low = 0;
        int hight = names.Count - 1;

        int counter = 0;

        while (low <= hight)
        {
            int middle = (low + hight) / 2;

            counter++;
            // Base case
            if (element == names[middle])
            {
                Console.WriteLine($"Number found at index: {middle}\n It took {counter} operations to complete");
                return;
            }

            else if (middle < names.IndexOf(element))
            {
                middle = (low + hight) / 2;
                low = middle + 1;

                if (names[middle] == element)
                {
                    Console.WriteLine($"Number found at index: {middle}\n It took {counter} operations to complete");
                    return;
                }

            }
            else if (middle > names.IndexOf(element))
            {
                hight = middle - 1;

                if (names[middle] == element)
                {
                    Console.WriteLine($"Number found at index: {middle}\n It took {counter} operations to complete");
                    return;
                }
            }
            else
            {
                low = middle + 1;
            }
        }
    }

    public static void LinearSearch(int element)
    {
        var data = new int[] { 6, 20, 41, 22, 12, 66, 78, 32, 41, 20, 18, 4, 65, 24, 56, 77, 29, 10 };

        // Check every element in the list, Rinning time O(n)
        for (int i = 0; i < data.Length; i++)
        {
            if (element == data[i])
            {
                Console.WriteLine($"Number found at index: {i}");
                return;
            }
        }

        Console.WriteLine("Number not found");
        return;
    }
}
