using System;
using System.Runtime.InteropServices;

namespace Cryptanalysis
{
public class Vigenere
{
    public const float FrenchIndexOfCoincidence = 0.0778F;
    private string key;
    public Vigenere(string key)
    {
        this.key = key;
        
    }

    public string Encrypt(string msg)
    {
        int n = 0;
        string res = "";
        string key = this.key;
        int l = key.Length;
        int taille = msg.Length;
        for (int i = 0; i < taille; i++)
        {
            if (n>=l)
            {
                n = 0;
            }
            if (Tools.LetterIndex(msg[i])==-1)
            {
                res = res + msg[i];
            }
            else
            {
                int x = Tools.LetterIndex(key[n]);
                res = res + Tools.RotChar(msg[i], x);

                n = n + 1;
            }
            
        }

        return res;
    }

    public string Decrypt(string cypherText)
    {
        int n = 0;
        string res = "";
        string key = this.key;
        int l = key.Length;
        int taille = cypherText.Length;
        for (int i = 0; i < taille; i++)
        {
            if (n>=l)
            {
                n = 0;
            }
            if (Tools.LetterIndex(cypherText[i])==-1)
            {
                res = res + cypherText[i];
            }
            else
            {
                int x = Tools.LetterIndex(key[n]);
                res = res + Tools.RotChar(cypherText[i], -x);

                n = n + 1;
            }
            
        }

        return res;
    }

    public static string GuessKeyWithLength(string cypherText, int keyLength)
    {
        throw new NotImplementedException();
    }
    
    public static float IndexOfCoincidence(string str)
    {
        throw new NotImplementedException();
    }

    public static int GuessKeyLength(string cypherText)
    {
        throw new NotImplementedException();
    }
    
    public static string GuessKey(string cypherText)
    {
        throw new NotImplementedException();
    }
}
}
