namespace AlgoritmosProject.Services;

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
        var result = new List<IList<int>>();

        int arrayLength = nums.Length;

        if (arrayLength < 4) return result;

        Array.Sort(nums);

        if (nums[arrayLength - 1] + nums[arrayLength - 2] + nums[arrayLength - 3] + nums[arrayLength - 4] < target)
        {
            return result;
        }

        for (int i = 0; i < arrayLength - 3; i++)
        {
            if (nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target)
            {
                break;
            }
            if (nums[i] + nums[arrayLength - 1] + nums[arrayLength - 2] + nums[arrayLength - 3] < target)
            {
                continue;
            }
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            int target2 = target - nums[i];
            for (int j = i + 1; j < arrayLength - 2; j++)
            {
                if (nums[j] + nums[j + 1] + nums[j + 2] > target2 ||
                    nums[arrayLength - 1] + nums[arrayLength - 2] + nums[arrayLength - 3] < target2)
                {
                    break;
                }
                if (nums[j] + nums[arrayLength - 1] < target2)
                {
                    continue;
                }
                if (j > i + 1 && nums[j] == nums[j - 1])
                {
                    continue;
                }
                int target3 = target2 - nums[j];
                int left = j + 1;
                int right = arrayLength - 1;
                while (left < right)
                {
                    int sum = nums[left] + nums[right];
                    if (sum == target3)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }
                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }
                        left++;
                        right--;
                    }
                    else if (sum < target3)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }
        return result;
    }
}
