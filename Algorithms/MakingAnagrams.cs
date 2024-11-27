public class MakingAnagrams
{
    public static int makeAnagram(string a, string b)
{
    // Frequency dictionaries for both strings
    Dictionary<char, int> freqA = new Dictionary<char, int>();
    Dictionary<char, int> freqB = new Dictionary<char, int>();
    
    // Populate frequency for string `a`
    foreach (char c in a)
    {
        if (freqA.ContainsKey(c))
            freqA[c]++;
        else
            freqA[c] = 1;
    }
    
    // Populate frequency for string `b`
    foreach (char c in b)
    {
        if (freqB.ContainsKey(c))
            freqB[c]++;
        else
            freqB[c] = 1;
    }
    
    int deletions = 0;

    // Check characters in `freqA`
    foreach (var kvp in freqA)
    {
        char charA = kvp.Key;
        int countA = kvp.Value;
        int countB = freqB.ContainsKey(charA) ? freqB[charA] : 0;

        // Add deletions needed for this character
        deletions += Math.Abs(countA - countB);

        // Remove from freqB to avoid double counting later
        freqB.Remove(charA);
    }

    // Check remaining characters in `freqB`
    foreach (var kvp in freqB)
    {
        deletions += kvp.Value; // Add all remaining characters in `freqB`
    }

    return deletions;
}

public static int makeAnagramString(string a, string b)
{
    // Iterate through each character in the alphabet
    for (char c = 'a'; c <= 'z'; c++)
    {
        // Find the count of `c` in both strings
        int countA = a.Count(ch => ch == c);
        int countB = b.Count(ch => ch == c);

        // Calculate the number of common occurrences
        int minCount = Math.Min(countA, countB);

        // Remove common characters manually
        a = RemoveCharacters(a, c, minCount);
        b = RemoveCharacters(b, c, minCount);
    }

    // Return the total remaining character count
    return a.Length + b.Length;
}

// Helper function to remove a specific number of characters
private static string RemoveCharacters(string str, char character, int count)
{
    var result = new List<char>();
    int removed = 0;

    foreach (var ch in str)
    {
        if (ch == character && removed < count)
        {
            removed++;
        }
        else
        {
            result.Add(ch);
        }
    }

    return new string(result.ToArray());
}



}