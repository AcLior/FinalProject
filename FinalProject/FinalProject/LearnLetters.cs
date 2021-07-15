using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FinalProject
{
    public partial class LearnLetters : Form
    {
        ListWords listW = new ListWords();
        SoundPlayer sp;
        int count=0;
        public LearnLetters()
        {
            InitializeComponent();
            sp = new SoundPlayer();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listW.W[count].FirstLetter.ToString() == cmbLetters.Text)
            {
                txtWord.Text = listW.W[count].Letters;
                count++;
            }

        }

        private void btnSound_Click(object sender, EventArgs e)
        {

        }
    }
}
