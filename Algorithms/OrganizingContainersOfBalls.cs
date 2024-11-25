public class OrganizingContainersOfBalls
{
    public static string organizingContainers(List<List<int>> container)
    {
         int n = container.Count;

        // Step 0: Validate the matrix dimensions
        if (n == 0 || container.Any(row => row == null || row.Count != n))
        {
            return "Impossible";
        }

        // Step 1: Calculate row sums (container capacities)
        List<long> rowSum = new List<long>(new long[n]);
        for (int i = 0; i < n; i++)
        {
            long sum = 0;
            foreach (var ball in container[i])
            {
                if (ball < 0)
                {
                    // Ensure no negative values are present
                    return "Impossible";
                }
                sum += ball;
            }
            rowSum[i] = sum;
        }

        // Step 2: Calculate column sums (ball type totals)
        List<long> colSum = new List<long>(new long[n]);
        for (int col = 0; col < n; col++)
        {
            long sum = 0;
            for (int row = 0; row < n; row++)
            {
                sum += container[row][col];
            }
            colSum[col] = sum;
        }

        // Step 3: Sort both lists
        rowSum.Sort();
        colSum.Sort();

        // Step 4: Compare sorted row sums with sorted column sums
        return rowSum.SequenceEqual(colSum) ? "Possible" : "Impossible";
    }
}