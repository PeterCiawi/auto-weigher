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
                        Tuple<string, double, double?> dataSelesai = new Tuple<string, double, double?>(first.Item1,
                            first.Item2, e.Weight);
                        thing.Text = first.Item1;
                        thing.SubItems.Add(first.Item2.ToString() + "g");
                        thing.SubItems.Add(first.Item3.ToString() + "g");
                        listView2.Items.Add(thing);

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
                
                var item = new ListViewItem();
                Tuple<string, double, double?> dataTimbang = new Tuple<string, double, double?>(cbNama.Text,
                    Convert.ToDouble(nmAngka.Value), null);
                antrian.Enqueue(dataTimbang);
                item.Text = cbNama.Text;
                string Value = Convert.ToString(nmAngka.Value);
                item.SubItems.Add(Value+"g");
                listView1.Items.Add(item);
                string berat = Convert.ToString(weigher);
                double nm = Convert.ToDouble(nmAngka.Value);
                
                weigher.Weight(nm);
               
                




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
