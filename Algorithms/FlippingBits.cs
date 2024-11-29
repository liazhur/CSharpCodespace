public class FlippingBits{
    public static long flippingBits(long n)
    {
        string s = Convert.ToString(n,2).PadLeft(32, '0');
     
       
        s = s.Replace("0","*");
        s = s.Replace("1","0");
        s = s.Replace("*","1");
        long l = Convert.ToInt64(s, 2);
        return l;
    }

}