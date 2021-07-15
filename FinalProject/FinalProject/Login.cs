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
    public partial class Login : Form
    {
        List<Player> players = new List<Player>();

        public Login()
        {
            InitializeComponent();
        }
        void AddPlayer(Player p)
        {
            players.Add(p);
        }
       
         bool Exists(Player p)
        {
            foreach (Player pl in players)
            {
                if (pl.Equals(p))
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblExist.Visible = false;
            lblError.Visible = false;

            try
            {
                Player p = new Player(txtEmail.Text);
                if (!Exists(p))
                {
                    AddPlayer(p);
                }
                else
                {
                    lblExist.Visible = true;
                    txtEmail.Focus();

                    return;
                }

                this.Hide();
                Menu m = new Menu();
                m.FormClosed += (s, args) => this.Close();

                m.Show();
            }

            catch (ArgumentException)
            {
                lblError.Visible = true;
            }
        }
    }
}
