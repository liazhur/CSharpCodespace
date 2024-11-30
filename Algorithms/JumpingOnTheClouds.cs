public class JumpingOnTheClouds{

    public static int jumpingOnClouds(List<int> c)
    {
        int jump=0;
        int index=0;
        
        while(index<c.Count-1)
        {
            if(index+2<c.Count && c[index+2]==0){index += 2;}
            else {index += 1;}
            jump++;
        }
        return jump;
    }
}