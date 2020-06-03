using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    /// <summary>
    /// Write a Function that takes in a non-empty array of distinct integer and aa integer representing a target sum.
    /// If any two numbers in the input array sum up to the larget sum, the function should return them in an array, in any order.
    /// If no two numbers sum up to the target sum,the function should return an empty array.
    /// 
    /// Example: [3,5,-4,8,11,1,-1,6] targetSum=10.
    /// Output: [-1,11]
    /// </summary>
    public class Two_Number_Sum
    {
        /// <summary>
        /// Brute Force Method.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public int[] TwoNumberSum1(int[] array, int targetSum)
        {
            // Write your code here.
            List<int> result = new List<int>();

            if (array.Length == 0 || array == null)
                return result.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int first = array[i];
                for (int j = i; j < array.Length; j++)
                {
                    int second = array[j];

                    if (i != j && targetSum == first + second)
                    {
                        result.Add(first);
                        result.Add(second);
                    }
                }
            }
            return result.ToArray();

            //Algo Code
            // ON square 
            //  array.Length - 1 --> beacuse last element is computed with all the before elements.
            //  int j = i + 1 --> beacuse we dont neeed to backward in computation process.
            for (int i = 0; i < array.Length - 1; i++)
            {
                int first = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    int second = array[j];

                    if (targetSum == first + second)
                    {
                        return new int[] { first, second };
                    }
                }
            }
        }

        /// <summary>
        /// With O(N) being N--> has length of array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public int[] TwoNumberSum2(int[] array, int targetSum)
        {
            // Write your code here.
            List<int> result = new List<int>();

            if (array.Length == 0 || array == null)
                return result.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int first = array[i];
                int second = targetSum - first;

                if (array.Contains(second) && first != second)
                {
                    result.Add(second);
                    result.Add(first);
                }
            }

            return result.Distinct().ToArray();

            //Algo Code
            //HashSet is a List with no duplicate members.
            //Because a HashSet is constrained to contain only unique entries, the internal structure is optimised for searching(compared with a list) - it is considerably faster
            //Adding to a HashSet returns a boolean - false if addition fails due to already existing in Set
            //Can perform mathematical set operations against a Set: Union/Intersection/IsSubsetOf etc.HashSet doesn't implement IList only ICollection

            HashSet<int> nums = new HashSet<int>();

            foreach (int num in array)
            {
                int required = targetSum - num;

                if (nums.Contains(required))
                {
                    return new int[] { num, required };
                }
                else
                {
                    nums.Add(num);
                }
            }
        }

        /// <summary>
        /// Using Dictionary
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public int[] TwoNumberSum3(int[] array, int targetSum)
        {
            // Write your code here.
            List<int> result = new List<int>();
            Dictionary<int, int> hasmap = new Dictionary<int, int>();

            if (array.Length == 0 || array == null)
                return result.ToArray();

            hasmap = Enumerable.Range(0, array.Length).ToDictionary(x => x, y => array[y]);

            for (int i = 0; i < array.Length; i++)
            {
                int first = array[i];
                int second = targetSum - first;

                if (hasmap.ContainsValue(second) && first != second)
                {
                    result.Add(second);
                    result.Add(first);
                }
            }
            return result.Distinct().ToArray();

            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;

            while(left < right)
            {
                int cuurentSum = array[left] + array[right];

                if(cuurentSum == targetSum)
                {
                    return new int[] { array[left], array[right] };
                }
                else if(cuurentSum < targetSum)
                {
                    left++;
                }
                else if(cuurentSum > targetSum)
                {
                    right--;
                }
            }

            return new int[0];
        }
    }
}
