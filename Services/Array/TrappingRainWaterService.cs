using System.Diagnostics;

namespace AlgoritmosProject.Services.Array;

public static class TrappingRainWaterService
{
    public static int Trap(int[] heights)
    {
        if (heights.Length == 0)
        {
            return 0;
        }

        int[] leftMax = new int[heights.Length];
        int[] rightMax = new int[heights.Length];

        leftMax[0] = heights[0];

        for (int i = 1; i < heights.Length; i++)
        {
            leftMax[i] = Math.Max(leftMax[i - 1], heights[i]);
        }

        rightMax[heights.Length - 1] = heights[^1];//heights[heights.Length - 1];

        for (int i = heights.Length - 2; i >= 0; i--)
        {
            rightMax[i] = Math.Max(rightMax[i + 1], heights[i]);
        }

        int trappedWater = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            Debug.WriteLine($"leftMax[{i}] -> {leftMax[i]} | rightMax[{i}] -> {rightMax[i]} | heights[{i}] -> {heights[i]}");
            Debug.WriteLine($"\t {Math.Min(leftMax[i], rightMax[i])} - {heights[i]} = {Math.Min(leftMax[i], rightMax[i]) - heights[i]}");
            trappedWater += Math.Min(leftMax[i], rightMax[i]) - heights[i];
        }

        return trappedWater;
    }
}
