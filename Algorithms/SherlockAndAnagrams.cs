public class SherlockAndAnagrams{

    public static int sherlockAndAnagram(string s)
{
    var substringCount = new Dictionary<string, int>();
    int count = 0;

    // Generate all substrings
    for (int i = 0; i < s.Length; i++)
    {
        for (int j = i + 1; j <= s.Length; j++)
        {
            // Extract substring
            string substring = s.Substring(i, j - i);

            // Sort the substring to use as a key
            char[] charArray = substring.ToCharArray();
            Array.Sort(charArray);
            string sortedSubstring = new string(charArray);

            // Increment dictionary count
            if (substringCount.ContainsKey(sortedSubstring))
            {
                substringCount[sortedSubstring]++;
            }
            else
            {
                substringCount[sortedSubstring] = 1;
            }
        }
    }

    // Count anagrammatic pairs
    foreach (var value in substringCount.Values)
    {
        if (value > 1)
        {
            count += value * (value - 1) / 2; // Count pairs directly
        }
    }

    return count;
}
}