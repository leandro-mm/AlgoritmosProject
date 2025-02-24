using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProject.Services
{
    public static class InPlaceService
    {
        public static int[] RemoveDuplicates(int[] inputArray)
        {
            if (inputArray.Length == 0)
            {
                throw new Exception("Array vazio");
            };

            var hashSet = inputArray.ToHashSet();
            return hashSet.ToArray();
        }

        public static int FindFirstDuplicate(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[Math.Abs(inputArray[i]) - 1] < 0)
                {
                    return Math.Abs(inputArray[i]);
                }
                else
                {
                    inputArray[Math.Abs(inputArray[i]) - 1] = -inputArray[Math.Abs(inputArray[i]) - 1];

                }

            }

            return -999;
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

        public static int FindMajorityByBoyerMoore(int[] nums)
        {
            int count = 0, candidate = -1;

            // Finding majority candidate
            foreach (var num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                    count = 1;
                }

                count += candidate == num ? 1:-1;
            }

            count = 0;
            foreach (var num in nums)
            {
                if (candidate == num) count++;
            }

            return count > (nums.Length/ 2) ? candidate : -1;
        }
    }
}
