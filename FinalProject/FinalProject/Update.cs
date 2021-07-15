using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    public partial class Update : Form
    {
        int length = 110;

        public Update()
        {
            InitializeComponent();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            int count = 0;
            string[] lines = File.ReadAllLines(@"DATA\wordImageData.txt");
            string[] arg;
            string newWord;
            while (count < length)
            {
                arg = lines[count].Split(';');

                if (txtWord.Text == arg[1].Trim())
                {
                    throw new Exception("The word already exist");

                }
                count++;
            }

            newWord = ++length + ";" + txtWord.Text + ";" + txtWord.Text + ".jpg ;" + txtWord.Text + ".wave ;" + txtWord.Text.Substring(0) + " ; " + txtWord.TextLength + " ;";
            using (StreamWriter sw = File.AppendText(@"DATA\wordImageData.txt"))
            {
                sw.WriteLine(newWord);

            }
            MessageBox.Show("המילה נוספה לרשימה");
            this.Hide();
            Menu m = new Menu();
            m.FormClosed += (s, args) => this.Close();
            m.Show();

        }
    }
}
