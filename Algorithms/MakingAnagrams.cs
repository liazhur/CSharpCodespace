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

}