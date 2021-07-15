using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FinalProject
{
    
    class ListWords
    {
        List<Word> words = new List<Word>();
        Card c;
        int length = 110;
        int count = 0;

        public ListWords()
        {
            ArrangeListWords();
        }

        public List<Word> W
        {
            get { return this.words; }
        }
        public void ArrangeListWords()
        {

            string[] arg;
            string[] lines = File.ReadAllLines(@"DATA\wordImageData.txt");

            while (count < length)
            {
                arg = lines[count].Split(';');
                c = new Card(arg[2].Trim(), arg[3].Trim(), char.Parse(arg[4].Trim()), int.Parse(arg[5].Trim()), arg[1].Trim());
                words.Add(c);
                count++;
            }


        }

        public void ShowList()
        {
            foreach (Word w in words)
            {
                Console.WriteLine(w);
            }
        }

    }
}
