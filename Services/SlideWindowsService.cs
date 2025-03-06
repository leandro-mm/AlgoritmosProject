namespace AlgoritmosProject.Services;

public static class SlideWindowsService
{
    public static void Sort3ColorsInPlace(int[] colors)
    {
        //--0 red
        //-- 1 white
        //-- 2 blue

        int redIndex = 0, whiteIndex = 0;
        int blueIndex = colors.Length - 1;

        while (whiteIndex <= blueIndex)
        {
            if (colors[whiteIndex] == 0)
            {
                Swap(ref colors[redIndex], ref colors[whiteIndex]);
                whiteIndex++;
                redIndex++;

            }
            else if (colors[whiteIndex] == 1)
            {
                whiteIndex++;
            }
            else
            {
                Swap(ref colors[whiteIndex], ref colors[blueIndex]);
                blueIndex--;
            }
           
        }
    }

    public static int[] FindLongestSubstringBySum(int[] input, int targetSum)
    {
        int left = 0;

        int right = 0;

        int currentSum = 0;

        int[] windowSum = [-1, -1];

        while (right < input.Length)
        {
            currentSum += input[right];

            if (currentSum == targetSum)
            {
                if (right - left > windowSum[1] - windowSum[0])
                {
                    windowSum = [left, right];
                }
            }
            else if (currentSum > targetSum)
            {
                while (left < right && currentSum > targetSum)
                {
                    currentSum -= input[left++];
                }
            }

            right++;
        }

        return windowSum;
    }

    public static int[] FindSmalestSubstringBySum(int[] input, int targetSum)
    {
        int left = 0;
        int right = 0;
        int currentSum = 0;
        int[] windowSum = [-1, -1];

        while (right < input.Length)
        {
            currentSum += input[right];

            if (currentSum == targetSum)
            {
                if((windowSum[0] + windowSum[1] < 0) || right-left < (windowSum[0] + windowSum[1]))
                {
                    windowSum[0] = left;
                    windowSum[1] = right;
                }
            }
            else if(currentSum > targetSum)
            {
                while (left < right && currentSum > targetSum)
                {
                    currentSum -= input[left++];
                }
            }

            right++;
        }

        return windowSum;
    }
    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
