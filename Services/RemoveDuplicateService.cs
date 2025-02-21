using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProject.Services
{
    public static class RemoveDuplicateService
    {
        public static int[] RemoveDuplicates(int[] inputArray)
        {   
            if(inputArray.Length == 0)
            {
                throw new Exception("Array vazio");
            };

            int slow = 0 ;
            List<int>  list = new([]);

            for (int fast = 1; fast < inputArray.Length; fast++)
            {

                if (inputArray[fast] != inputArray[slow])
                {
                    list.Add(inputArray[slow]);                    
                }

                Debug.WriteLine($"slow {slow} fast {fast}");

                slow++;
                
            }

            return list.ToArray();


        }

        public static int RemoveDuplicatesNewLength(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int uniqueIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[uniqueIndex])
                {
                    uniqueIndex++;
                    nums[uniqueIndex] = nums[i];
                }
            }

            return uniqueIndex + 1;
        }
    }
}
