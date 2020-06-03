using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    /// <summary>
    /// Write a function that takes in two non empty arrays of integers, finds the pair of numbers(one from each array) whose absolute
    /// differnce is closest to zero, and returns an array containing these two numbers, with the number from the first array in first.
    /// </summary>
    public class Smallest_Difference
    {
        /// <summary>
        /// Regular Approach with O(N2)
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public int[] SmallestDifference(int[] arr1, int[] arr2)
        {
            int cs = Int32.MaxValue;
            int[] result= new int[2];
            foreach(int i in arr1)
            {
                foreach(int j in arr2)
                {
                    int temp = Math.Abs(i-j);                    

                    if(temp<cs)
                    {
                        result = new int[] { i,j};
                        cs = Math.Abs(i - j);
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns></returns>
        public int[] SmallestDifference1(int[] arrayOne, int[] arrayTwo)
        {            
            return null;
        }
    }
}