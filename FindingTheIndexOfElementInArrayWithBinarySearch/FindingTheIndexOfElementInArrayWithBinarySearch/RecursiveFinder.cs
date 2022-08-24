namespace FindingTheIndexOfElementInArrayWithBinarySearch
{
    public class RecursiveFinder
    {
        public void RecursiveFinde(int[] array, int first, int last, int key)
        {
            int middle = (first + last) / 2;
            if (first == last)
            {
                Console.WriteLine(last);
            }
            else if (key == array[middle])
            {
                Console.WriteLine(middle + 1);
            }
            else if (key > array[middle])
            {
                RecursiveFinde(array, middle + 1, last, key);
            }
            else
            {
                RecursiveFinde(array, first, last - 1, key);
            }
        }
    }
}