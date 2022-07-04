namespace MyLib;
using System;
public class Ex
{
    public static int [,] GetArray (int m, int n)
    {
        int [,] result=new double [m, n];
        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                result[i,j]=new Random().Next(-100,101);
            }
        }
    return result;
    }
}
