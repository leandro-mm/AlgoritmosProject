namespace AlgoritmosProject.Services
{
    public static class FirstDuplicateService
    {
        public static int FindFirstDuplicate(int[] inputArray)
        {
            for (int i = 0;i<inputArray.Length; i++)
            {
                if ( inputArray[Math.Abs(inputArray[i]) - 1] < 0)
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
    }
}
