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
    public partial class SelectWeight : Form
    {
        public Lib.AutoWeigher Weigher { get; set; }
        public SelectWeight()
          
        {
            InitializeComponent();
                btnOk.Enabled = false;
            

            

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Weigher = new Lib.AutoWeigher(cbSelect.Text);
            Mains adds = new Mains(Weigher);
            adds.Show();
            
            
            if (cbSelect.Text == "")
            {
                this.Controls.Add(btnOk);
            }
            
                
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            this.Controls.Add(btnOk);
        }

        private void SelectWeight_Load(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < AutoWeigher.Lib.AutoWeigher.PortNames.Length; i++)
            {
                cbSelect.Items.Add(AutoWeigher.Lib.AutoWeigher.PortNames[i]);
                x = i;
            }
        }
    }
}
