namespace AutoWeigher
{
    namespace Main
    {

        partial class Mains
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Berat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTmbh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbNama = new System.Windows.Forms.ComboBox();
            this.nmAngka = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nmAngka)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nama,
            this.Berat});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 18);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(264, 487);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nama
            // 
            this.Nama.Text = "Nama";
            // 
            // Berat
            // 
            this.Berat.Text = "Berat";
            // 
            // btnTmbh
            // 
            this.btnTmbh.Location = new System.Drawing.Point(898, 126);
            this.btnTmbh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTmbh.Name = "btnTmbh";
            this.btnTmbh.Size = new System.Drawing.Size(147, 35);
            this.btnTmbh.TabIndex = 1;
            this.btnTmbh.Text = "Manage Bahan";
            this.btnTmbh.UseVisualStyleBackColor = true;
            this.btnTmbh.Click += new System.EventHandler(this.btnTmbh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1070, 126);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Timbang";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbNama
            // 
            this.cbNama.FormattingEnabled = true;
            this.cbNama.Location = new System.Drawing.Point(1000, 14);
            this.cbNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNama.Name = "cbNama";
            this.cbNama.Size = new System.Drawing.Size(180, 28);
            this.cbNama.TabIndex = 3;
            this.cbNama.SelectedValueChanged += new System.EventHandler(this.cbNama_SelectedValueChanged);
            // 
            // nmAngka
            // 
            this.nmAngka.DecimalPlaces = 2;
            this.nmAngka.Location = new System.Drawing.Point(1002, 63);
            this.nmAngka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmAngka.Name = "nmAngka";
            this.nmAngka.Size = new System.Drawing.Size(180, 26);
            this.nmAngka.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(914, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(914, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Berat";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(315, 18);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(457, 487);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nama";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Berat";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hasil";
            // 
            // Mains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmAngka);
            this.Controls.Add(this.cbNama);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnTmbh);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mains";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Mains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmAngka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.ListView listView1;
            private System.Windows.Forms.Button btnTmbh;
            private System.Windows.Forms.Button btnAdd;
            private System.Windows.Forms.ComboBox cbNama;
            private System.Windows.Forms.NumericUpDown nmAngka;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.ColumnHeader Nama;
            private System.Windows.Forms.ColumnHeader Berat;
            private System.Windows.Forms.ListView listView2;
            private System.Windows.Forms.ColumnHeader columnHeader1;
            private System.Windows.Forms.ColumnHeader columnHeader2;
            private System.Windows.Forms.ColumnHeader columnHeader3;
        }
    }
}

