namespace AutoWeigher.Main
{
    partial class AddThings
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
            this.nmAngka = new System.Windows.Forms.NumericUpDown();
            this.txtNm = new System.Windows.Forms.TextBox();
            this.lblJmlh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmAngka)).BeginInit();
            this.SuspendLayout();
            // 
            // nmAngka
            // 
            this.nmAngka.DecimalPlaces = 2;
            this.nmAngka.Location = new System.Drawing.Point(73, 44);
            this.nmAngka.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmAngka.Name = "nmAngka";
            this.nmAngka.Size = new System.Drawing.Size(120, 20);
            this.nmAngka.TabIndex = 0;
            this.nmAngka.ValueChanged += new System.EventHandler(this.nmAngka_ValueChanged);
            // 
            // txtNm
            // 
            this.txtNm.Location = new System.Drawing.Point(73, 9);
            this.txtNm.Name = "txtNm";
            this.txtNm.Size = new System.Drawing.Size(120, 20);
            this.txtNm.TabIndex = 1;
            this.txtNm.TextChanged += new System.EventHandler(this.txtNm_TextChanged);
            // 
            // lblJmlh
            // 
            this.lblJmlh.AutoSize = true;
            this.lblJmlh.Location = new System.Drawing.Point(12, 44);
            this.lblJmlh.Name = "lblJmlh";
            this.lblJmlh.Size = new System.Drawing.Size(40, 13);
            this.lblJmlh.TabIndex = 2;
            this.lblJmlh.Text = "Jumlah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(41, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "No";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(107, 79);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(39, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // AddThings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 125);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblJmlh);
            this.Controls.Add(this.txtNm);
            this.Controls.Add(this.nmAngka);
            this.Name = "AddThings";
            this.Text = "AddThings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddThings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmAngka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmAngka;
        private System.Windows.Forms.TextBox txtNm;
        private System.Windows.Forms.Label lblJmlh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}