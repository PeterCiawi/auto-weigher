using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AutoWeigher;
using AutoWeigher.Lib;

namespace AutoWeigher
{
    namespace Main
    {

        public partial class Mains : Form
        {
            Queue<Tuple<string, double, double?>> antrian = new Queue<Tuple<string, double, double?>>();

            Lib.AutoWeigher weigher ;
            
            void UpdateList()
            {
                listView1.Items.Clear();
                foreach (var antri in antrian)
                {
                    var item = new ListViewItem();
                    item.Text = antri.Item1;
                    item.SubItems.Add(antri.Item2.ToString()+"g");
                    listView1.Items.Add(item);
                }
            }
            void Weight()
            {
                if (antrian.Count > 0)
                {
                    weigher.Weight(antrian.Peek().Item2);
                }
            }
            

          
            

            

            public Mains(Lib.AutoWeigher Weigher)
            {
                weigher = Weigher;
                weigher.WeightDone += Weigher_WeightDone;
                weigher.Begin();
                InitializeComponent();
            }

            private void Weigher_WeightDone(object sender, WeightDoneArgs e)
            {
                if (listView2.InvokeRequired)
                {
                    listView2.Invoke((MethodInvoker)delegate ()
                    {
                        var thing = new ListViewItem();
                        var first = antrian.Dequeue();
                        UpdateList();
                        Tuple<string, double, double?> dataSelesai = new Tuple<string, double, double?>(first.Item1,
                            first.Item2, e.Weight);
                        thing.Text = dataSelesai.Item1;
                        thing.SubItems.Add(dataSelesai.Item2.ToString() + "g");
                        thing.SubItems.Add(dataSelesai.Item3.ToString() + "g");
                        listView2.Items.Add(thing);
                        Weight();









                    });
                }
                
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
                Tuple<string, double, double?> dataTimbang = new Tuple<string, double, double?>(cbNama.Text,
                    Convert.ToDouble(nmAngka.Value), null);
                antrian.Enqueue(dataTimbang);
                
                UpdateList();
                if (!weigher.IsWeighing)
                {
                    Weight();
                }
                


















            }

            private void cbNama_SelectedValueChanged(object sender, EventArgs e)
            {
                Resep YgDipilih = (Resep)cbNama.SelectedItem;
                nmAngka.Value = Convert.ToDecimal(YgDipilih.Code);
            }

            private void listView1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }
    }
}
