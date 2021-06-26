using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWeigherMain
{
    public partial class AddThings : Form
    {
        public Resep ResepBaru { get; private set; }
        public AddThings()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Resep resep = new Resep()
            {
                Nama = txtNm.Text,
                Code = Convert.ToDouble(nmAngka.Value)
            };
            ResepBaru = resep;
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
