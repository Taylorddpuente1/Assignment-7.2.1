//Implement shell sort on an unsorted array of numbers. Take the array input from user.

namespace MyProgram
{
    class Program
    {
        static void ShellSort(int[] arr)
        {
            int gap = arr.Length / 2;
            int i, j;
            while (gap > 0)
            {
                i = gap;
                while (i < arr.Length)
                {
                    int temp = arr[i];
                    j = i - gap;
                    while (j >= 0 && arr[j] > temp)
                    {
                        arr[j + gap] = arr[j];
                        j = j - gap;
                    }
                    arr[j + gap] = temp;
                    i++;
                }
                gap = gap / 2;

            }
        }
        static void Main()
        {
            int[] arr = { 3, 6, 7, 3, 2, 9 };
            ShellSort(arr);

            foreach (var num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
