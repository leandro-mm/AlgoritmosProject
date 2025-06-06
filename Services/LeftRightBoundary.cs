﻿namespace AlgoritmosProject.Services;

public static class LeftRightBoundary
{
    public static Dictionary<int,int> TwoSum(int[] input, int target)
    {
        Dictionary<int, int> keyValuePairs = new();

        int left = 0, right = input.Length - 1;

        while (left < right)
        {
            if (input[left] + input[right] == target)
            {
                keyValuePairs.Add(left, input[left]);
                keyValuePairs.Add(right, input[right]);

                break;
            }
            else
            {
                if (input[left] + input[right] > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

        return keyValuePairs;
    }
    
    public static IList<IList<int>> FourSum(int[] nums, int target)
    {
        
        return [];
    }
}
