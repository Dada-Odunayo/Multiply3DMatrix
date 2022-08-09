namespace Multiply3DMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array initialization
            int[,,] arr3d1 = new int[3, 3, 2]
            {
               {
                    {5,2},{ 3,4},{3,2}
                },
               {
                    {5,30},{ 7,8},{4,15}
                },
               {
                    {1,2},{ 3,4},{1,9}
                }
            };


            int[,,] arr3d2 = new int[3, 2, 2]
            {
               {
                    {1,2},{ 3,4}
                },
               {
                    {5,6},{ 7,8}
                },
               {
                    {1,2},{ 3,4}
                }
            };

            //a third array declared to hold multiplied values

            int[,,] arr3d3 = new int[3, 2, 2];

            for(int i = 0; i < arr3d1.GetLength(0); i++)
            {
                for(int j = 0; j < arr3d2.GetLength(1); j++)
                {
                    for(int k = 0; k < arr3d2.GetLength(2); k++)
                    {
                        arr3d3[i,j,k] += arr3d1[i, j, k] * arr3d2[i, k,j];
                    }
                }
            }

            //loops through the new array to print to the console
            foreach(int i in arr3d3)
            {
                Console.WriteLine(i);
            }
        }
    }
}