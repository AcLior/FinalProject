using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Card : Word
    {

        string image;
        string audio;
        public Card(string image, string audio, char firstLetter, int length, string letters) :base(firstLetter, length, letters)
        {
            Image = image;
            Audio = audio;
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        public string Audio
        {
            get { return audio; }
            set { audio = value; }
        }

    }
}
