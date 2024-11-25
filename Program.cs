using System;

class Program {
  public static void Main (string[] args) {
    
    //Console.WriteLine (BiggerIsGreater.biggerIsGreater("abcd"));
    //Console.WriteLine(string.Join(" ", AbsolutePermutation.absolutePermutation(4, 2)));
    
    Console.WriteLine(OrganizingContainersOfBalls.organizingContainers(new List<List<int>> 
    {
        new List<int> {0, 2, 1},
        new List<int> {1, 1, 1},
        new List<int> {2, 0, 0}
    }));

  }

  
  
  
}