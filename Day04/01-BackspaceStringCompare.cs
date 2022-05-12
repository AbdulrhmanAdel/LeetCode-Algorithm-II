using System;
using System.Collections.Generic;

namespace AlgorithmII.Day04
{
    public class BackspaceStringCompare
    {
        public static void Run()
        {
            Console.WriteLine(BackspaceCompare(
                "bxj##tw",
                "bxo#j##tw"));
            // "ab#c",
            // "ad#c"));
        }

        public static bool BackspaceCompare(string s, string t)
        {
            if (s == t)
                return true;

            // s: ab#c
            // t: ad#c
            // "bxj##tw"
            // "bxo#j##tw"
            int sIndex = s.Length - 1,
                tIndex = t.Length - 1,
                skipS = 0,
                skipT = 0;

            while (sIndex >= 0 || tIndex >= 0)
            {
                while (sIndex >= 0)
                {
                    // bxj##tw
                    if (s[sIndex] == '#')
                    {
                        skipS++;
                        sIndex--;
                    }
                    else if (skipS > 0)
                    {
                        skipS--;
                        sIndex--;
                    }
                    else
                    {
                        break;
                    }
                }

                while (tIndex >= 0)
                {
                    if (t[tIndex] == '#')
                    {
                        skipT++;
                        tIndex--;
                    }
                    else if (skipT > 0)
                    {
                        skipT--;
                        tIndex--;
                    }
                    else
                    {
                        break;
                    }
                }

                if (sIndex >= 0 && tIndex >= 0  && s[sIndex] != t[tIndex]) return false;
                if ((sIndex >= 0) != (tIndex >= 0))
                    return false;
                sIndex--;
                tIndex--;
            }

            return true;
        }
    }
}