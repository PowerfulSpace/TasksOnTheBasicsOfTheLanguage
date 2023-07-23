


int[] sortArray = new int[] { 7, 1, 3, 2 };

bool swapped = true;
do
{
    swapped = false;
    for (int i = 0; i < sortArray.Length - 1; i++)
    {
        if (sortArray[i] > sortArray[i + 1])
        {
            int temp = sortArray[i];
            sortArray[i] = sortArray[i + 1];
            sortArray[i + 1] = temp;
            swapped = true;
        }
    }
} while (swapped);

foreach (var item in sortArray)
{
    Console.Write(item + " ");
}

Console.ReadLine();