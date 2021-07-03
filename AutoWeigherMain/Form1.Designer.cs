namespace AutoWeigher
{
    namespace Main
    {

        partial class Form1
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
                this.Hasil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.Berat,
            this.Hasil});
                this.listView1.GridLines = true;
                this.listView1.Location = new System.Drawing.Point(12, 12);
                this.listView1.Name = "listView1";
                this.listView1.Size = new System.Drawing.Size(177, 318);
                this.listView1.TabIndex = 0;
                this.listView1.UseCompatibleStateImageBehavior = false;
                this.listView1.View = System.Windows.Forms.View.Details;
                // 
                // Nama
                // 
                this.Nama.Text = "Nama";
                // 
                // Berat
                // 
                this.Berat.Text = "Berat";
                // 
                // Hasil
                // 
                this.Hasil.Text = "Hasil";
                // 
                // btnTmbh
                // 
                this.btnTmbh.Location = new System.Drawing.Point(622, 82);
                this.btnTmbh.Name = "btnTmbh";
                this.btnTmbh.Size = new System.Drawing.Size(75, 23);
                this.btnTmbh.TabIndex = 1;
                this.btnTmbh.Text = "Tambahkan";
                this.btnTmbh.UseVisualStyleBackColor = true;
                this.btnTmbh.Click += new System.EventHandler(this.btnTmbh_Click);
                // 
                // btnAdd
                // 
                this.btnAdd.Location = new System.Drawing.Point(713, 82);
                this.btnAdd.Name = "btnAdd";
                this.btnAdd.Size = new System.Drawing.Size(75, 23);
                this.btnAdd.TabIndex = 2;
                this.btnAdd.Text = "AddToList";
                this.btnAdd.UseVisualStyleBackColor = true;
                this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
                // 
                // cbNama
                // 
                this.cbNama.FormattingEnabled = true;
                this.cbNama.Location = new System.Drawing.Point(667, 9);
                this.cbNama.Name = "cbNama";
                this.cbNama.Size = new System.Drawing.Size(121, 21);
                this.cbNama.TabIndex = 3;
                this.cbNama.SelectedValueChanged += new System.EventHandler(this.cbNama_SelectedValueChanged);
                // 
                // nmAngka
                // 
                this.nmAngka.Location = new System.Drawing.Point(668, 41);
                this.nmAngka.Name = "nmAngka";
                this.nmAngka.Size = new System.Drawing.Size(120, 20);
                this.nmAngka.TabIndex = 4;
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(609, 9);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(35, 13);
                this.label1.TabIndex = 5;
                this.label1.Text = "Nama";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(609, 41);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(32, 13);
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
                this.listView2.Location = new System.Drawing.Point(210, 12);
                this.listView2.Name = "listView2";
                this.listView2.Size = new System.Drawing.Size(306, 318);
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
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(800, 450);
                this.Controls.Add(this.listView2);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.label1);
                this.Controls.Add(this.nmAngka);
                this.Controls.Add(this.cbNama);
                this.Controls.Add(this.btnAdd);
                this.Controls.Add(this.btnTmbh);
                this.Controls.Add(this.listView1);
                this.Name = "Form1";
                this.Text = "Form1";
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
            private System.Windows.Forms.ColumnHeader Hasil;
            private System.Windows.Forms.ListView listView2;
            private System.Windows.Forms.ColumnHeader columnHeader1;
            private System.Windows.Forms.ColumnHeader columnHeader2;
            private System.Windows.Forms.ColumnHeader columnHeader3;
        }
    }
}

