using System;

namespace Cryptanalysis
{
public static class Tools
{
    public static int Modulus(int a, int b)
    {
        if (b < 0)
            b = -b;
        
        var mod = a % b;
        return mod < 0 ? b + mod : mod;
    }

    public static int LetterIndex(char c)
    {
        int res = -1;
        //maj
        if (c>64 && c<91)
        {
            res = c - 65;
        }
        
        if (c>96 && c<123)
        {
            res = c - 97;
        }

        return res;


    }
    
    public static char RotChar(char c, int n)
    {
        int index = LetterIndex(c);
        int res = 0;
        if (index==-1)
        {
            return c;
        }
        
        if (c>64 && c<91)
        {
            res = index + n;
            res = Modulus(res, 26);
            res = res + 65;
        }
        
        if (c>96 && c<123)
        {
            res = index + n;
            res = Modulus(res, 26);
            res = res + 97;
        }

        char res2 = (char) res;

        return res2;



    }

    public static int[] Histogram(string str)
    {
        int[] histo = new int[26];
        Console.WriteLine(histo[25]);

        foreach (var a in str)
        {
            int w = LetterIndex(a);
            if (w!=-1)
            {
                histo[w] = histo[w] + 1;
            }
        }

        return histo;
    }
    
    public static string FilterLetters(string str)
    {
        throw new NotImplementedException();
    }

    public static string Extract(string str, int start, int step)
    {
        throw new NotImplementedException();
    }
}
}