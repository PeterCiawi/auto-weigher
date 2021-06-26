using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoWeigherMain
{
    public partial class Form1 : Form
    {
        Queue<Tuple<string, double, double?>> antrian = new Queue<Tuple<string, double, double?>>();
        void WeightDone(this , );
        
        public Form1()
        {




            InitializeComponent();
        }

        private void btnTmbh_Click(object sender, EventArgs e)
        {
            AddThings add = new AddThings();
            add.ShowDialog();
            if (add.DialogResult == DialogResult.OK)
            {
                cbNama.Items.Add(add.ResepBaru);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var item = new ListViewItem();
            var thing = new ListViewItem();
            Tuple<string, double, double?> dataTimbang = new Tuple<string, double, double?>(cbNama.Text,
                Convert.ToDouble(nmAngka.Value), null);
            antrian.Enqueue(dataTimbang);
            item.Text = cbNama.Text;
            string Value = Convert.ToString(nmAngka.Value);
            item.SubItems.Add(Value);
            listView1.Items.Add(item);
            
            var first = antrian.Dequeue();
            Tuple<string, double, double?> dataSelesai = new Tuple<string, double, double?>(first.Item1,
                first.Item2, null);
            thing.Text = first.Item1;
            thing.SubItems.Add(first.Item2.ToString());
            thing.SubItems.Add(first.Item3.ToString());
            listView2.Items.Add(thing);
           
            


        }

        private void cbNama_SelectedValueChanged(object sender, EventArgs e)
        {
            Resep YgDipilih =(Resep)cbNama.SelectedItem;
            nmAngka.Value = Convert.ToDecimal(YgDipilih.Code);
        }
    }
}
