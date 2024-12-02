public class MinimumBribes{
    public static void minimumBribes(List<int> q)
{
    int count = 0;

    for (int i = 0; i < q.Count; i++)
    {
        // Check if the current person has moved more than 2 places ahead
        if (q[i] - (i + 1) > 2)
        {
            Console.WriteLine("Too chaotic");
            return;
        }

        // Count the number of overtakes for this person
        for (int j = (q[i] - 2 > 0 ? q[i] - 2 : 0); j < i; j++)
        {
            if (q[j] > q[i])
            {
                count++;
            }
        }
    }

    Console.WriteLine(count);
}
}