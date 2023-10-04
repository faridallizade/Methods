namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //int[] array = { 34, 65, 2, 5, 2562, 52, 0 };
            //MinNumber(array);
            //
            //

            //Task 2
            //CheckSquare(25, 5);
            //
            //

            //Task 3
            //int[] array = { 1, 2, 3, 5, 6, 7, 8 };
            //ascendingOrder(array);
            //
            //

            //Task 4
            //string word = "Emergency";
            //char letter = 'e';
            //int result =  FindCharIndex(letter, word);
            //if(result == -1)
            //{
            //    Console.WriteLine("The letter could not find in word");
            //}
            //else
            //{
            //    Console.WriteLine("The letter's index is " + result);
            //}
            //
            //


        }
        #region Task 1
        public static void MinNumber(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {


                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine("The minimum element of array is  " + min);
        }
        #endregion
        #region Task 2 
        public static void CheckSquare(int square,int number)
        {
            if(square == number * number)
            {
                Console.WriteLine("The first number is square of the second number");
            }
            else
            {
                Console.WriteLine("The frist number is not square of the second number");
            }
        }
        #endregion
        #region Task 3
        public static void ascendingOrder(int[] array)
        {
            bool Result;
            Result = true;
            for(int i = 0; i < array.Length-1;i++)
            {
                if (array[i] < array[i + 1])
                {
                    Result = true; 
                }
                else
                {
                    Result = false;
                    break;
                }
            }
            if(Result)
            {
                Console.WriteLine("The numbers are arranged in ascending order");
            }
            else
            {
                Console.WriteLine("The numbers are mixed");
            }
        }
        #endregion
        #region Task 4
        public static int FindCharIndex(char letter, string word)
        {
            for(int i = 0;i < word.Length;i++)
            {
                if (char.ToLower(word[i]) == char.ToLower(letter))
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion
    }
}


