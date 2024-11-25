public class HourglassSum
{
       public static int hourglassSum(List<List<int>> arr)
    {
        int maxSum = int.MinValue;
        for(int i=0; i<=3; i++)
        {
            for(int j=0;j<=3;j++)
            {
                int currentSum = arr[i][j]+arr[i][j+1]+arr[i][j+2]
                +arr[i+1][j+1]
                +arr[i+2][j]+arr[i+2][j+1]+arr[i+2][j+2];

                maxSum = currentSum>maxSum ? currentSum : maxSum;
            }
        }
        return maxSum;
    }

}