using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWeigher.Main
{
    public partial class Login : Form
    {
        public bool show = false;
        public Login()
        {
            InitializeComponent();
            
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (txtUN.Text == "AutoWeigher" & txtPass.Text == "Segitiga")
            {
                
                SelectWeight add = new SelectWeight();
                add.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username Atau Password anda salah", "Silahkan isi dengan yang benar", MessageBoxButtons.OK);
                {
                    txtPass.Text = "";
                    txtUN.Text = "";
                }
                
            }
           
        }

        

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
            txtPass.ForeColor = Color.Black;
            txtPass.PasswordChar = '*';
            
        }

        

        private void CbEye_CheckedChanged(object sender, EventArgs e)
        {
            if (CbEye.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
