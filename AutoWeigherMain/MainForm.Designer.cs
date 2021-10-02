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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmAngka)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nama,
            this.Berat});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(246, 399);
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
            this.btnTmbh.Location = new System.Drawing.Point(17, 81);
            this.btnTmbh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTmbh.Name = "btnTmbh";
            this.btnTmbh.Size = new System.Drawing.Size(117, 28);
            this.btnTmbh.TabIndex = 3;
            this.btnTmbh.Text = "Manage Bahan";
            this.btnTmbh.UseVisualStyleBackColor = true;
            this.btnTmbh.Click += new System.EventHandler(this.btnTmbh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(151, 81);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Timbang";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbNama
            // 
            this.cbNama.FormattingEnabled = true;
            this.cbNama.Location = new System.Drawing.Point(67, 16);
            this.cbNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNama.Name = "cbNama";
            this.cbNama.Size = new System.Drawing.Size(160, 24);
            this.cbNama.TabIndex = 0;
            this.cbNama.SelectedValueChanged += new System.EventHandler(this.cbNama_SelectedValueChanged);
            // 
            // nmAngka
            // 
            this.nmAngka.DecimalPlaces = 2;
            this.nmAngka.Location = new System.Drawing.Point(69, 49);
            this.nmAngka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmAngka.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmAngka.Name = "nmAngka";
            this.nmAngka.Size = new System.Drawing.Size(160, 22);
            this.nmAngka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Berat";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(258, 4);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(246, 399);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 407);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbNama);
            this.panel1.Controls.Add(this.btnTmbh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nmAngka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(511, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 401);
            this.panel1.TabIndex = 0;
            // 
            // Mains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mains";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Mains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmAngka)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            private System.Windows.Forms.Panel panel1;
        }
    }
}

