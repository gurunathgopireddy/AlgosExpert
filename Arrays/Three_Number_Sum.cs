using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arrays
{
    /// <summary>
    /// Write a Function that takes in a non emprty array of distinct integers and an integer representing a target sum.
    /// The function should find all triplets in the array that sum up to the target sum and return a two-dimensional array of all these triplets.
    /// The Numbers in each triplet should be ordered in ascending order, and the triplets themselves should be ordered in ascending order with respect to the numbers.
    /// </summary>
    public class Three_Number_Sum
    {
        /// <summary>
        /// Regular Approach with O(N3) cube time complexity.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public List<int[]> ThreeNumberSum1(int[] array, int targetSum)
        {
            List<int[]> output = new List<int[]>();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length - 1; j++)
                {
                    for (int z = 2; z < array.Length - 2; z++)
                    {
                        if (targetSum == array[i] + array[j] + array[z] && array[i] != array[j] && array[j] != array[z] && array[z] != array[i])
                        {
                            output.Add((new int[] { array[i], array[j], array[z] }).Distinct().OrderBy(i => i).ToArray());
                        }
                    }
                }
            }
           return output.Distinct().ToList();            
        }

        /// <summary>
        /// 1. First sort Array
        /// 2. Take first element in array as current Number(CN) and two pointers (L, R)
        ///     Eample:[-8,-6,1,2,3,5,6,12]
        ///            (CN),L            R.
        ///     First (CS)=> CN+L+R = targetsum or NOT
        ///     If CS>targetsum
        ///         move R pointer to LEFT by 1
        ///        CS(lessthan) targetsum
        ///         move L pointer to RIGHT by 1
        ///        CS= targetsum
        ///         move both L & R by 1
        ///      If both pointer macthes or passes then move CN to next number.
        /// 3.Time Complexity: O(N2) square. Space=O(N).
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public List<int[]> ThreeNumberSum2(int[] array, int targetSum)
        {
            List<int[]> output = new List<int[]>();

            Array.Sort(array);

            for (int i = 0; i < array.Length-2; i++)
            {
                int l = i + 1;
                int r = array.Length - 1;

                while(l<r)
                {
                    int cs = array[i] + array[l] + array[r];

                    if(cs==targetSum)
                    {
                        output.Add(new int[] { array[i], array[l], array[r]});
                        l++;
                        r--;
                    }

                   else if(cs>targetSum)
                    {
                        //r=r-1
                        r--;
                    }

                    else if(cs<targetSum)
                    {
                        //l=l+1
                        l++;
                    }                    
                }
            }

            return output;
        }
    }
}
