using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffFilter
{
    public static int[] Diff(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            if(i != 0)
            {
                result[i] = xs[i - 1] - xs[i];
            }
            else
            {
                result[i] = xs[i];
            }
            
        }

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] < 0)
            {
                result[i] = result[i] * -1;
            }
        }
            return result;
    }
}

