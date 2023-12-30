using DZ_4_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Stack
{
    private List<string> elements;
    public Stack(params string[] strings)
    {
        elements = new List<string>(strings);
    }

    public void Add(string element)
    {
        elements.Add(element);
    }

    public string Pop()
    {

        if (Size == 0)
        {
            throw new InvalidOperationException("Стек пустой");
        }
        string topElement = elements[Size - 1];
        elements.RemoveAt(Size - 1);
        return topElement;

    }

    public int Size
    {
        get
        {
            return elements.Count;
        }
    }

    public string Top
    {
        get
        {
            if (Size == 0)
            {
                return "null";
            }
            return elements[Size - 1];
        }
    }
    public string Bop()
    {

        if (Size == 0)
        {
            throw new InvalidOperationException("Стек пустой");
        }
        string bottomElement = elements[0];
        elements.RemoveAt(0);
        return bottomElement;

    }
}
