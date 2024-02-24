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
                return null;
            }
            return elements[Size - 1];
        }
    }

    public static Stack Concat(params Stack[] stacks)
    {
           Stack concatenatedStack = new Stack();

          foreach (Stack stack in stacks)
        {
           while (stack.Size > 0)
            {
                concatenatedStack.Add(stack.Pop());
            }
          
            
        }

        return concatenatedStack;
    }


    public void GetContents(string stackName)
    {
        Console.WriteLine($"в стеке '{stackName}' теперь элементы -");
        foreach (var element in elements)
        {
            Console.Write(element);
            Console.Write($" ");
        }
        Console.WriteLine();
    }
}
 