using System;

namespace lesson10
{
    internal class Array : IOutput2, ICalc2
    {
        int[] nums;

        public Array(int[] numbers)
        {
            nums = numbers;
        }

        #region task1

        public void ShowEven()
        {
            foreach (int i in nums)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void ShowOdd()
        {
            foreach (int i in nums)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        #endregion

        #region task2

        public int CountDistinct()
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                bool exists = false;

                for (int j = 0; j < i; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        exists = true;
                    
                    }
                }

                if (!exists)
                {
                    count++;
                }
            }

            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;

            foreach (int i in nums)
            {
                if (i == valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }

        #endregion
    }
}