using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_zadaca_3
{
    public partial class Form1 : Form
    {
        string username="narucitelj";
        string password="test";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordTxt.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (UsernameTxt.Text == username && PasswordTxt.Text == password )
                {
                    UnZah UnZah = new UnZah();
                    Hide();
                    UnZah.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void logForma()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(316, 248);
            this.Name = "Form1";
            this.Text = "Prijava u sistem";
            this.ResumeLayout(false);

        }
    }
}
