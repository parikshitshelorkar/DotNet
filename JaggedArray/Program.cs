// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[][] arr = new int[3][] {
  new int[] {11, 21, 56},
  new int[] {2, 5, 6, 7},
  new int[] {2, 5}
};

Console.WriteLine("Jagged Array Elements:");
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr[i].Length; j++)
    {
        Console.Write(arr[i][j] + " ");
    }
    Console.WriteLine();
}