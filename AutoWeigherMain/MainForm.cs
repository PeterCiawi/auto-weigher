using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AutoWeigher;
using AutoWeigher.Lib;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace AutoWeigher
{
    namespace Main
    {
        public partial class Mains : Form
        {

            Queue<Tuple<string, double, double?>> antrian = new Queue<Tuple<string, double, double?>>();

            public List<Resep> Recipes = new List<Resep>();

            void saveItems()
            {
                if (File.Exists(configPath))
                {
                    string jsonSavedItems = JsonSerializer.Serialize(Recipes);
                    File.WriteAllText(configPath, Convert.ToString(jsonSavedItems));
                }
                else
                {
                    var empty = new List<Resep>();
                    var emptyJson = JsonSerializer.Serialize(empty);
                    File.WriteAllText(configPath, emptyJson);
                }
            }

            List<Resep> loadItems()
            {
                if (File.Exists(configPath))
                {
                    List<Resep> readItems = JsonSerializer.Deserialize<List<Resep>>(File.ReadAllText(configPath));

                    return readItems;
                }
                else
                {
                    var empty = new List<Resep>();
                    var emptyJson = JsonSerializer.Serialize(empty);
                    File.WriteAllText(configPath, emptyJson);
                    return empty;
                }
            }

            Lib.AutoWeigher weigher;

            void UpdateList()
            {
                listView1.Items.Clear();
                foreach (var antri in antrian)
                {
                    var item = new ListViewItem();
                    item.Text = antri.Item1;
                    item.SubItems.Add(antri.Item2.ToString() + "g");
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

            public readonly static string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

            public Mains(Lib.AutoWeigher Weigher)
            {
                this.Load += Mains_Load;
                weigher = Weigher;
                weigher.WeightDone += Weigher_WeightDone;
                weigher.Begin();
                InitializeComponent();
                btnAdd.Enabled = false;
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
                AddThings.loadedListSavedItems = Recipes;
                add.ShowDialog();
                var listItem = JsonSerializer.Deserialize<List<Resep>>(File.ReadAllText(configPath));
                cbNama.Items.Clear();
                foreach (var resep in listItem)
                {
                    cbNama.Items.Add(resep);
               }

                var lastsavedItems = JsonSerializer.Serialize(listItem);
                File.WriteAllText(configPath, lastsavedItems);

                saveItems();

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

                UpdateList();
                if (!weigher.IsWeighing)
                {
                    Weight();
                }
                if (cbNama.Text == "")
                {
                    this.Controls.Add(btnAdd);
                }
            }

            private void cbNama_SelectedValueChanged(object sender, EventArgs e)
            {
                Resep YgDipilih = (Resep)cbNama.SelectedItem;
                nmAngka.Value = Convert.ToDecimal(YgDipilih.Code);
                btnAdd.Enabled = true;
                this.Controls.Add(btnAdd);
            }

            private void Mains_Load(object sender, EventArgs e)
            {

                if (!File.Exists(configPath))
                {
                    var empty = new List<Resep>();
                    var emptyJson = JsonSerializer.Serialize(empty);
                    File.WriteAllText(configPath, emptyJson);
                }
                Recipes = loadItems();

                foreach (var items in Recipes)
                {
                    cbNama.Items.Add(items);

                }
            }
        }
    }
}
