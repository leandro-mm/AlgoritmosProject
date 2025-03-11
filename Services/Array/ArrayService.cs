namespace AlgoritmosProject.Services.Array;

public static  class ArrayService
{
    public static int MaxSumOfArray(int[] nums) {

        int maxSum = nums[0];

        int currentSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);

            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}
