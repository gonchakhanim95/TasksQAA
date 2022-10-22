namespace TasksQA
{
    public static class Arrays
    {
        public static int FindMaxNumber(int[] myArray) //1
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

        public static int FindMinNumber(int[] myArray2) //2
        {
            int minVelue = myArray2[0];
            for (int i = 0; i < myArray2.Length; i++)
            {

                if (minVelue > myArray2[i])
                {
                    minVelue = myArray2[i];
                }

            }
            return minVelue;
        }


        public static int FindMaxIndex(int[] myArray3) //3
        {
            int max = myArray3[0];
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

        public static int FindMinIndex(int[] myArray4)//4
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

        public static int SumOddIndex(int[] myArray5) //5 
        {
            int sum = 0;
            for (int i = 1; i < myArray5.Length; i += 2)
            {
                sum += myArray5[i];

            }
            return sum;
        }

        public static int[] ArrayReversed(int[] myArray6) //6?
        {
            int temp = 0;
            for (int i = myArray6.Length-1; i >= 0; i--)
            {
                temp-= myArray6[i];
            }
            return myArray6;
        }

        public static int[] BubbleSort(int[] myArray9) //9
        {

            for (int i = 0; i < myArray9.Length; i++)
            {
                int minIndex = i;
                for (int j = 0; j < myArray9.Length - 1; j++)
                {
                    if (myArray9[j] > myArray9[j + 1])
                    {
                        minIndex = myArray9[j];
                        myArray9[j] = myArray9[j + 1];
                        myArray9[j + 1] = minIndex;
                    }
                }
            }
            return myArray9;
        }
        

    }
}
