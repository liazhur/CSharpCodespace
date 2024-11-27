public class GreedyAlgorithm
{
    public static int minimumAbsoluteDifference(List<int> arr)
    {
        arr.Sort();
        int result= Math.Abs(arr[0]-arr[1]);
        
        for(int i =0; i<arr.Count-1; i++)
        {
            int tempResult = Math.Abs(arr[i] - arr[i + 1]);
            if (tempResult < result)
            {
                result = tempResult;
            }
        }
        return result;
    }
}