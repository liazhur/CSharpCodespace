public class FrequencyQueries
{
    static List<int> freqQuery(List<List<int>> queries) {
        
        List<int> output = new List<int>();
        
        Dictionary<int,int> d = new Dictionary<int, int>();
        
        foreach(List<int> query in queries)
        {
            if(query[0]==1)
            {
               if(d.ContainsKey(query[1])) 
                {d[query[1]]++;}
                else{d.Add(query[1],1);}
            }
            if(query[0]==2)
            {
                if(d.ContainsKey(query[1])&& d[query[1]]>0)
                {d[query[1]]--;}
            }
            if(query[0]==3)
            {
                if(d.ContainsValue(query[1]))
                {output.Add(1);}
                else{output.Add(0);}
            }
        }
        return output;
    }
}