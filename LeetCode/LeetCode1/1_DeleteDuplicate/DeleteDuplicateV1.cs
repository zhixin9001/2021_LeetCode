using System;

namespace LeetCode1._1_DeleteDuplicate
{
    public class DeleteDuplicateV1 
    {
        public static void Imp()
        {
            // int[] nums = Array.Empty<int>();
            int[] nums = new int[]{1,2,2,3,3,3,4,5,5};
            if (nums.Length==0)
            {
                return;;  
            }
            int left = 0, right = 0;
            for (left = 0; left < nums.Length; left++)
            {
                for (right = left +1;  right< nums.Length; right++)
                {
                    if (nums[right] > nums[left])
                    {
                        break;
                    }
                }

                if (right >= nums.Length)
                {
                    break;
                }
                for (int i = left+1; i < right; i++)
                {
                    nums[i] = nums[right];
                }
            }
            
            Console.WriteLine($"Length= {left+1}");
            foreach (var i in nums)
            {
                Console.Write(i+" "); 
            }
        }
    }
}