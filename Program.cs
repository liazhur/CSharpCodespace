using System;

class Program {
  public static void Main (string[] args) {
    
    //Console.WriteLine(BiggerIsGreater.biggerIsGreater("abcd"));

    //Console.WriteLine(string.Join(" ", AbsolutePermutation.absolutePermutation(4, 2)));
    
    // Console.WriteLine(OrganizingContainersOfBalls.organizingContainers(new List<List<int>> 
    // {
    //     new List<int> {0, 2, 1},
    //     new List<int> {1, 1, 1},
    //     new List<int> {2, 0, 0}
    // }));

    //Console.WriteLine(SalesByMatch.sockMerchant(9, [10, 20, 20, 10, 10, 30, 50, 10, 20]));

    // Console.WriteLine(HourglassSum.hourglassSum(new List<List<int>>
    // {
    // new List<int> { 1, 1, 1, 0, 0, 0 },
    // new List<int> { 0, 1, 0, 0, 0, 0 },
    // new List<int> { 1, 1, 1, 0, 0, 0 },
    // new List<int> { 0, 0, 2, 4, 4, 0 },
    // new List<int> { 0, 0, 0, 2, 0, 0 },
    // new List<int> { 0, 0, 1, 2, 4, 0 }
    // }));

  //   RansomNote.checkMagazine(
  //   new List<string> { "give", "me", "one", "grand", "today", "night" },
  //   new List<string> { "give", "one", "grand", "today" }
  //   );

  //   RansomNote.checkMagazine(
  //   new List<string> { "hello", "world" },
  //   new List<string> { "Hello" }
  //   );
  

  //Console.WriteLine(MakingAnagrams.makeAnagram("fcrxzwscanmligyxyvym","jxwtrhvujlmrpdoqbisbwhmgpmeoke"));
  //Console.WriteLine(MakingAnagrams.makeAnagramString("fcrxzwscanmligyxyvym","jxwtrhvujlmrpdoqbisbwhmgpmeoke"));
  //Console.WriteLine(GreedyAlgorithm.minimumAbsoluteDifference(new List<int> {3, -7, 0}));
 // Console.WriteLine(Fibonacci.fibonacci(6));

  //Console.WriteLine(FlippingBits.flippingBits(2147483647));

  //Console.WriteLine(JumpingOnTheClouds.jumpingOnClouds(new List<int> {0,0,0,0,1,0}));

  //Console.WriteLine(RepeatedString.repeatedString("aba", 10));
     
  //MinimumBribes.minimumBribes(new List<int> {2,1,5,3,4});
  //Console.WriteLine(MinimumSwaps2.minimumSwaps([4,3,1,2]));

  //Console.WriteLine(CountTriplets.countTriplets(new List<long> {1,3,9,9,27,81}, 3));
  // Console.WriteLine(CountTriplets.countTripletsOtpimized(new List<long> {1,3,9,9,27,81}, 3));


        int n = 5; // Size of the array
        List<List<int>> queries = new List<List<int>>
        {
            new List<int> { 1, 2, 100 }, // Add 100 to elements 1 through 2
            new List<int> { 2, 5, 100 }, // Add 100 to elements 2 through 5
            new List<int> { 3, 4, 100 }  // Add 100 to elements 3 through 4
        };
        Console.WriteLine(ArrayManipulation.arrayManipulationOptimized(n, queries));




  
  }
  
}