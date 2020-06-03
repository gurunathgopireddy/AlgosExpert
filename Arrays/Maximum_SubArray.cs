using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    /// <summary>
    /// 
    /// </summary>
    public class Maximum_SubArray
    {
        public class Solution
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="nums"></param>
            /// <returns></returns>
            public int MaxSubArray(int[] nums)
            {

                int sum = nums[0];
                int targetSum = nums[0];

                for (int i = 1; i < nums.Length; i++)
                {
                    if (sum < 0)
                    {
                        sum = nums[i];
                    }
                    else
                    {
                        sum = sum + nums[i];
                    }

                    targetSum = Math.Max(sum, targetSum);
                }

                return targetSum;
            }
        }
    }
}
