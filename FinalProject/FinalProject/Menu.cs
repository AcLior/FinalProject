using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LearnLetters pwg = new LearnLetters();
            pwg.FormClosed += (s, args) => this.Close();
            pwg.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update upage = new Update();
            upage.FormClosed += (s, args) => this.Close();
            upage.Show();
        }
    }
}
