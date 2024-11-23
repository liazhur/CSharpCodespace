public class BiggerIsGreater
{
public static string biggerIsGreater(string w)
  {
      char[] charW = w.ToCharArray();
      int n = charW.Length;

      // Step 1: Find the pivot (rightmost character smaller than its next )
      int pivot = -1;
      for (int i = n - 2; i >= 0; i--)
      {
          if (charW[i] < charW[i + 1])
          {
              pivot = i;
              break;
          }
      }

      // If no pivot is found, there's no lexicographically larger permutation
      if (pivot == -1)
      {
          return "no answer";
      }

      // Step 2: Find the successor (smallest character greater than pivot in the suffix)
      int successor = -1;
      for (int i = n - 1; i > pivot; i--)
      {
          if (charW[i] > charW[pivot])
          {
              successor = i;
              break;
          }
      }

      // Step 3: Swap the pivot and successor
      char temp = charW[pivot];
      charW[pivot] = charW[successor];
      charW[successor] = temp;

      // Step 4: Reverse the suffix
      Array.Reverse(charW, pivot + 1, n - pivot - 1);

      return new string(charW);
  }
}