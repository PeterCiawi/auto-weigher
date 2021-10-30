
namespace AutoWeigher.Main
{
    partial class SelectWeight
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(102, 70);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(56, 13);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(121, 21);
            this.cbSelect.TabIndex = 0;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            this.cbSelect.Click += new System.EventHandler(this.cbSelect_Click);
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(56, 40);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(121, 20);
            this.TxtIP.TabIndex = 2;
            this.TxtIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(15, 43);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(20, 13);
            this.labelIP.TabIndex = 3;
            this.labelIP.Text = "IP ";
            // 
            // SelectWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 104);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.TxtIP);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectWeight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Weight";
            this.Load += new System.EventHandler(this.SelectWeight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Label labelIP;
    }
}