using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Net.Http;
using System.Threading;
using Newtonsoft.Json;
using Types;

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

        public static List<Resep> loadedListSavedItems;
        readonly string baseUrl = "http://192.168.100.10:8888";

        public async void SaveResep(Resep resep)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, $"{baseUrl}/resep");
                string resepJson = JsonConvert.SerializeObject(resep);
                message.Content = new StringContent(resepJson);
                var responseMessage = await client.SendAsync(message);

                try
                {
                    responseMessage.EnsureSuccessStatusCode();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Data tidak berhasil disimpan. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
      
        private void btnOk_Click(object sender, EventArgs e)
        {
            Types.Resep resep = new Types.Resep()
            {
                Nama = txtNm.Text,
                Berat = Convert.ToDouble(nmAngka.Value)
            };

            loadedListSavedItems.Add(resep);
            ResepBaru = resep;
            this.DialogResult = DialogResult.OK;
            var newresep = resep;

            SaveResep(newresep);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
