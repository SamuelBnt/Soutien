using System;

namespace Cryptanalysis
{
public class Caesar
{

    private int key;
    public Caesar(int key)
    {
        this.key = key;
    }

    public string Encrypt(string msg)
    {
        string res = "";
        int taille = msg.Length;
        for (int i = 0; i < taille; i++)
        {

            res = res +Tools.RotChar(msg[i], key);
            
        }

        return res;
    }

    public string Decrypt(string cypherText)
    {
        string res = "";
        int taille = cypherText.Length;
        for (int i = 0; i < taille; i++)
        {

            res = res +Tools.RotChar(cypherText[i], -key);
            
        }

        return res;
    }
    
    public static int GuessKey(string cypherText)
    {
        
        int[] histo = Tools.Histogram(cypherText);
        int taille = histo.Length;
        int maxi = 0;
        for (int i = 0; i < taille; i++)
        {
            if (histo[maxi]<histo[i])
            {
                maxi = i;
            }
        }

        int res = 4 - maxi;
        return res;

    }
}
}