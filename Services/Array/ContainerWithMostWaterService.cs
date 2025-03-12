namespace AlgoritmosProject.Services.Array;

public static class ContainerWithMostWaterService
{
    public static int ContainerWithMostWater(int[] heights)
    {
        int maxArea = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right)
        {            
            int area = Math.Min(heights[left], heights[right]) * (right - left);

            maxArea = Math.Max(maxArea, area);

            if (heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}
