public class ArrayManipulation{

    public static long arrayManipulation(int n, List<List<int>> queries)
    {
    long answer = 0;
        
        List<long> arr2 = new List<long>(n);
        for(int i = 0; i< n; i++)
        {
             arr2.Add(0);
        }
            
            foreach(List<int> query in queries)
            {
                for(int i=query[0];i<=query[1];i++)
                {
                    arr2[i-1]+=query[2];                
                }
            }
        answer = arr2.Max();
    
            
       
    return answer;
    }

    public static long arrayManipulationOptimized(int n, List<List<int>> queries)
{
    long[] arr2 = new long[n + 1];

    foreach (var query in queries)
    {
        int start = query[0];
        int end = query[1];
        int value = query[2];

        arr2[start - 1] += value; 
        if (end < n)
        {
            arr2[end] -= value; 
        }
    }

    long max = 0;
    long currentSum = 0;
    for (int i = 0; i < n; i++)
    {
        currentSum += arr2[i];
        if (currentSum > max)
        {
            max = currentSum;
        }
    }

    return max;
}
}