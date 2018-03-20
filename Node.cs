using SBSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class Node
{
    public Node leftNode;
    public Word word;
    public Node rightNode;
    public Node() { }
    public Node (Word word)
    {
        this.word = word;
    }
}
