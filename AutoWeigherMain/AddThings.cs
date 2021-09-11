﻿using System;
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
    public partial class AddThings : Form
    {
        public Resep ResepBaru { get; private set; }
        public AddThings()
        {
            InitializeComponent();
            btnOk.Enabled = false;
           
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

        private void AddThings_Load(object sender, EventArgs e)
        {

        }

        private void txtNm_TextChanged(object sender, EventArgs e)
        {
            
            decimal nol = 0M;
            if (txtNm.Text != "" & nmAngka.Value != nol)
            {
                btnOk.Enabled = true;
                
            }
        }

        private void nmAngka_ValueChanged(object sender, EventArgs e)
        {
            decimal nol = 0M;
            if (txtNm.Text != "" & nmAngka.Value != nol)
            {
                btnOk.Enabled = true;
                
            }
        }
    }
}
