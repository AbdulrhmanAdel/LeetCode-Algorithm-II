using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmII.Day05
{
    public class FindAllAnagramsInAString
    {
        public static void Run()
        {
            var problem = new FindAllAnagramsInAString();
            var result = problem.FindAnagrams("cbaebabacd", "abc");
        }

        public IList<int> FindAnagrams(string s, string p)
        {
            var sn = s.Length;
            var pn = p.Length;
            var res = new List<int>();
            if (sn<=0 || pn<=0) return res;
        
            var pArr = new int[26];
            for (var i = 0; i < pn; i ++)
            {
                var c = p[i];
                pArr[(int)(c-'a')] ++;
            }
        
            var sArr = new int[26];
            for (var i = 0; i < sn; i ++)
            {
                var c = s[i];
                sArr[(c-'a')] ++;
                if (i>=pn)
                {
                    var c2 = s[i-pn];
                    sArr[(c2-'a')] --;
                }
            
                if (pArr.SequenceEqual(sArr))
                {
                    res.Add(i-pn+1);
                }
            }
        
            return res;
        }
    }
}