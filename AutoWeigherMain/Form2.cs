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
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Weigher = new Lib.AutoWeigher(cbSelect.Text);
            Mains adds = new Mains();
            adds.ShowDialog();
            if (adds.DialogResult == DialogResult.OK)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
