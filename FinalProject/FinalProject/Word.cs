using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Word:IComparable
    {
        int length;
        char firstLetter;
        string letters;
        public Word(char firstLetter, int length, string letters)
        {
            Length = length;
            FirstLetter = firstLetter;
            Letters = letters;

        }


        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public char FirstLetter
        {
            get { return firstLetter; }
            set { firstLetter = value; }
        }

        public string Letters
        {

            get { return letters; }
            set { letters = value; }

        }

        public int CompareTo(object obj)
        {
            Word w = (Word)obj;
            if (Length < w.Length)
            {
                return -1;
            }
            if (Length > w.Length)
            {
                return 1;
            }
            return 0;
        }
    }
}
