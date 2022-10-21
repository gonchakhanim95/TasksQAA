namespace TasksQA
{
    public static class Arrays
    {
        public static int FindMaxNumber(int[] myArray)
        {
            int maxValue = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (maxValue < myArray[i])
                {
                    maxValue = myArray[i];
                }

            }
            return maxValue;

        }

        public static int FindMinNumber(int[] myArray2)
        {
            int minVelue = 1;
            for (int i = 0; i < myArray2.Length; i++)
            {

                if (minVelue > myArray2[i])
                {
                    minVelue = myArray2[i];
                }

            }
            return minVelue;
        }


        public static int FindMaxIndex(int[] myArray3)
        {
            int max = myArray3[5];
            int index = 0;
            for (int i = 0; i < myArray3.Length; i++)
            {
                if (max < myArray3[i])
                {
                    max = myArray3[i];
                    index = i;
                }
            }
            return index;


        }

        public static int FindMinIndex(int[] myArray4)
        {
            int min = myArray4[0];
            int index = 0;
            for (int i = 0; i < myArray4.Length; i++)
            {
                if (min > myArray4[i])
                {
                    min = myArray4[i];
                    index = i;
                }
            }
            return index;


        }

        public static int SumOddIndex(int[] myArray5)
        {
            int sum = 0;
            for (int i = 1; i < myArray5.Length; i += 2)
            {
                sum += myArray5[i];

            }
            return sum;
        }

        

    }
}
