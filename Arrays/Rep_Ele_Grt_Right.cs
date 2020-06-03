using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Arrays
{
    public class Rep_Ele_Grt_Right
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] ReplaceElements(int[] arr)
        {
            List<int> output = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int[] newaarr =new  int[arr.Length-1-i];

                Array.Copy(arr,i+1, newaarr,0, arr.Length - 1 - i);               

                int great = newaarr.OrderByDescending(i => i).FirstOrDefault();

                output.Add(great);
            }

            output.RemoveAt(output.Count-1);

            output.Add(-1);

            return output.ToArray();
        }

        public int[] ReplaceElements1(int[] arr)
        {
            int k = arr.Length;
            int max = -1;
            int temp = arr[k - 1];
            arr[k - 1] = max;

            for (int i = k-2; i >= 0; i--)
            {
                max = Math.Max(max, temp);
                temp = arr[i];
                arr[i] = max;
            }

            return arr;
        }
    }
}
