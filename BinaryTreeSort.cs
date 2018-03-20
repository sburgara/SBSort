using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SBSort
{
    public class BinaryTreeSort
    {
        public Word[] list;
        private Node root;

        public BinaryTreeSort(Word[] list)
        {
            this.list = list;
        }

        public Word[] sort()
        {
            if (list == null)
                throw new Exception("List to sort is null");
            if (list.Length < 1)
                throw new Exception("List must contain at least one member");                        

            //create tree
            foreach(Word i in list)
            {
                add(i,root);
            }

            //Sort
            List<Word> result = new List<Word>();
            return inOrderTransversal(root, result).ToArray<Word>();
        }

        private void add(Word word, Node node)
        {
            if (node == null)
            {
                //Root
                root = new Node();
                root.word = word;
                return;
            }
            else
            {
                if(word.index < node.word.index)
                {
                    if(node.leftNode==null)
                    {
                        node.leftNode = new Node(word);
                        return;
                    }
                    else
                    {
                        add(word, node.leftNode);
                        return;
                    }
                }
                else if (word.index >= node.word.index)
                {
                    if (node.rightNode == null)
                    {
                        node.rightNode = new Node(word);
                        return;
                    }
                    else
                    {
                        add(word, node.rightNode);
                        return;
                    }
                }
            }
        }

        private List<Word> inOrderTransversal(Node node, List<Word> resultList)
        {
            if (node == null) return resultList;
            inOrderTransversal(node.leftNode, resultList);            
            resultList.Add(node.word);
            inOrderTransversal(node.rightNode, resultList);
            return resultList;
        }
    }
}
