public class JaggedArr
{
     int[][] number = new int[5][];
     public void printArr()
      {
        number[0] = new int[2]{ 5, 0 };
        number[1] = new int[4] { 6, 8, 2, 0 };
        number[2] = new int[3] { 1, 3, 2 };
        number[3] = new int[4] { 10, 20, 30, 40 };
        number[4] = new int[5] { 6, 7, 8, 80, 7 };

        for (int i = 0; i < number.Length; i++)
        {
            System.Console.Write("Array num :"+(i+1) +" : ");
            for (int j = 0; j < number[i].Length; j++)
            {
                System.Console.Write(" "+number[i][j]);
            }

            System.Console.WriteLine();
        }

    }
}
