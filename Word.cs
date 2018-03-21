using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SBSort
{
    public class Word
    {
        public int times;
        public string word;
        public BigInteger index = 0;

        public Word(string word)
        {
            this.word = word;
            this.index = getIndex();
        }

        public int getSizeOfWord()
        {
            return word.Length;
        }

        public BigInteger getIndex()
        {
            BigInteger radix = BigInteger.Parse("10000000000000000000000000000000000000000");
            BigInteger index = 0;
            foreach (char c in word.ToLower())
            {
                char cc = ' ';
                switch (c)
                {
                    case 'á':
                        cc = 'a';
                        break;
                    case 'é':
                        cc = 'e';
                        break;
                    case 'í':
                        cc = 'i';
                        break;
                    case 'ó':
                        cc = 'o';
                        break;
                    case 'ú':
                        cc = 'u';
                        break;
                    case 'ñ':
                        cc = 'n';
                        break;
                    default:
                        cc = c;
                        break;
                }
                int num = (int)cc -96;
                index += (BigInteger)(num * radix);
                radix = radix / 100;
            }
            return index;
        }

        public static Word[] ToWordArray(string[] words)
        {
            int i = 0;
            Word[] result = new Word[words.Length];
            foreach (string word in words)
            {
                Word thisword = new Word(word.Trim());
                result[i++] = thisword;
            }
            return result;
        }
    }
}
