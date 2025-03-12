namespace AlgoritmosProject.Services.Array;

public static class FindMinimumRotatedSortedArrayService
{
    public static int FindMinimumInRotatedSortedArray(int[] nums)
    {

       

        int start = 0;

        int end = nums.Length - 1;

        while (start < end)
        {
            int mid = start + (end - start) / 2;

            if (nums[mid] >= nums[end])
            {
                start = mid + 1;
            }
            else
            {
                end = mid;
            }
        }

        return nums[start];

    }
}
