using System.Reflection.Metadata;

public class AbsolutePermutation
{
    public static List<int> absolutePermutation(int n, int k)//4,2
    {
        List<int> result = new List<int>();

    // If k == 0, return the identity permutation [1, 2, ..., n]
    if (k == 0)
    {
        for (int i = 1; i <= n; i++)
        {
            result.Add(i);
        }
        return result;
    }

    // If n is not divisible by 2k, a valid permutation is impossible
    if (n % (2 * k) != 0)
    {
        return new List<int> { -1 };
    }

    // Construct the permutation in blocks of size 2k
    for (int i = 1; i <= n; i++)
    {
        if (((i - 1) / k) % 2 == 0)
        {
            // For even blocks, add i + k
            result.Add(i + k);
        }
        else
        {
            // For odd blocks, add i - k
            result.Add(i - k);
        }
    }

    return result;
    }
}