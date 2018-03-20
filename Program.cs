using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SBSort
{


    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<BigInteger, Word> dictionary = new Dictionary<BigInteger, Word>();
            
            List<BigInteger> listIndexes = new List<BigInteger>();

            if (args.Length == 0)
            {
                Console.WriteLine("Must provide text file to sort");
                return;
            }

            string fileToSort = args[0];
            if(!File.Exists(AppDomain.CurrentDomain.BaseDirectory+"\\" + fileToSort))
            {
                Console.WriteLine("Invalid file");
                return;
            }

            string fileContent = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\" + fileToSort);
            string[] allWords = fileContent.Split(' ');

            //Words
            Word[] words = Word.ToWordArray(allWords);


            // Just if you want to see result by index
            /*
            StringBuilder listOfIndexes = new StringBuilder();
            foreach(Word w in words)
            {
                listOfIndexes.AppendLine(w.word + "\t" + w.index);
            }
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\list.txt", listOfIndexes.ToString());
            */


            BinaryTreeSort treeSort = new BinaryTreeSort(words);
            Word[] result = treeSort.sort();
            StringBuilder resultString = new StringBuilder();
            foreach (Word i in result)
            {
                resultString.AppendLine(i.word);
            }
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\output.txt", resultString.ToString());
            



        }
    }
}
