namespace assignmentc_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region one D array

            int[] numbers;
            //declare for refrence (pointers) from type 'array of integers '
            // numbers : can refer to object from type 'array of integers'
            // numbers : refer to null

            // 8 bytes will be allocated at stack for the refrence 'numbers'
            // 0 bytes will be allocated at heap


            //numbers = new int[size];
            numbers = new int[5];

            //new 
            //1. allocate the numbers of required bytes for the object at heap (4 bytes * 5)
            //2. intialize the allocated bytes with the default value of the database
            //3. call user-defined constructor if exists 
            //4. assign the object to the reference 'numbers'

            //numbers[0] = 12;
            //numbers[1] = 6;
            //numbers[2] = 7;
            //numbers[3] = 11;
            //numbers[4] = 19;
            ////numbers[5] = 20; // out of range 


            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[4]);

            //int[] numbers01 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] numbers02 = new int[4] { 1, 2, 3, 4 };
            //int[] numbers03 = new int[6] { 1, 2, 3, 4, 0, 0 };
            //int[] numbers04 = new int[6];

            //Console.WriteLine("enter numbers[0]:");
            //numbers[0] = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter numbers[1]:");
            //numbers[1] = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter numbers[2]:");
            //numbers[2] = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter numbers[3]:");
            //numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter numbers[4]:");
            //numbers[4] = int.Parse(Console.ReadLine());

            //for(int i = 0;i<numbers.Length; i++)
            //{
            //    Console.Write($"enter numbers[{i}] :");
            //    numbers[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} :");

            //}

            ////one D array

            //Console.WriteLine(numbers.Length); //size
            //Console.WriteLine(numbers.Rank);   //dimention  
            #endregion


            #region two D array

            //two D array

            //int[,] marks = new int[3, 3];

            //marks[0, 0] = 99;
            //marks[0, 1] = 99;
            //marks[0, 2] = 99;

            //marks[1, 0] = 80;
            //marks[1, 1] = 98;
            //marks[1, 2] = 97;

            //marks[2, 0] = 88;
            //marks[2, 1] = 98;
            //marks[2, 2] = 47;

            //for(int i = 0;i<3;i++)
            //{
            //    for(int j = 0;j<3;j++)
            //    {
            //        Console.Write($"enter marks[{i},{j}] :");
            //        marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{marks[i,j]}");

            //    }
            //} 
            #endregion

            //int[][] marks = new int[3][];

            //marks[0] = new int[]{ 1,2,3};
            //marks[1] = new int[] { 1, 2};
            //marks[2] = new int[] { 1, 2, 3 ,4};




        }
    }
}
