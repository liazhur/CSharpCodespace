public class RepeatedString{

    public static long repeatedString(string s, long n)
    {
        long countS =0; 
        long countTotal =0; 
        
        char[] arrS = s.ToCharArray();
            //count a in s
            for(int i=0;i<arrS.Length;i++)
            {
                if(arrS[i]=='a'){countS++;}
            }
            
            
        if(s.Length==1 && s=="a"){return n;}
        if(n<=s.Length)
        {            
            return countS;      
        }
        else if(n>s.Length)
        {
        long subs = n/s.Length;
        countTotal = subs*countS;
        long remainder = n-(subs*s.Length);
            for(int i=0; i<remainder;i++)
            {
                if(arrS[i]=='a'){countTotal++;}
            }
        }
        return countTotal;
    }

}