using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StackExtensions
{
    public static void Merge(this Stack s1, Stack s2)
    {
        
        while (s2.Size > 0)
        {
            s1.Add(s2.Pop());
        }
    }
}
