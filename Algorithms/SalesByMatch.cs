public class SalesByMatch
{
    public static int sockMerchant(int n, List<int> ar)
    {
        Dictionary<int,int> socks = new Dictionary<int,int>();
        
        foreach(int sock in ar)
        {
            if(socks.ContainsKey(sock))
            {
                socks[sock] = socks[sock]+1;
            }
            else socks.Add(sock, 1);   
        }
        
        int pairs =0;
        foreach(var sock in socks)
        {   
            pairs+=sock.Value/2;  
        }
        return pairs;
    }

    public static int sockMerchantImproved(int n, List<int> ar)
{
    // Dictionary to store the count of each sock type
    Dictionary<int, int> sockCounts = new Dictionary<int, int>();
    
    foreach (int sock in ar)
    {
        // Increment the count if the sock exists; otherwise, initialize it to 1
        if (sockCounts.ContainsKey(sock))
        {
            sockCounts[sock]++;
        }
        else
        {
            sockCounts[sock] = 1;
        }
    }
    
    int totalPairs = 0;

    // Calculate the total number of pairs for each sock type
    foreach (var sock in sockCounts)
    {
        totalPairs += sock.Value / 2; // Integer division gives the number of pairs
    }
    
    return totalPairs;
}

}