namespace derstextboks
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
            this.txtadres = new System.Windows.Forms.Label();
            this.txtozgecmıs = new System.Windows.Forms.Label();
            this.txtkaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtad = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.Label();
            this.txtmaas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtadres
            // 
            this.txtadres.AutoSize = true;
            this.txtadres.Location = new System.Drawing.Point(31, 28);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(36, 13);
            this.txtadres.TabIndex = 2;
            this.txtadres.Text = "adres:";
            // 
            // txtozgecmıs
            // 
            this.txtozgecmıs.AutoSize = true;
            this.txtozgecmıs.Location = new System.Drawing.Point(13, 89);
            this.txtozgecmıs.Name = "txtozgecmıs";
            this.txtozgecmıs.Size = new System.Drawing.Size(54, 13);
            this.txtozgecmıs.TabIndex = 4;
            this.txtozgecmıs.Text = "özgeçmiş:";
            // 
            // txtkaydet
            // 
            this.txtkaydet.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtkaydet.Location = new System.Drawing.Point(52, 303);
            this.txtkaydet.Name = "txtkaydet";
            this.txtkaydet.Size = new System.Drawing.Size(126, 63);
            this.txtkaydet.TabIndex = 5;
            this.txtkaydet.Text = "kaydet";
            this.txtkaydet.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtmaas);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Location = new System.Drawing.Point(20, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 165);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtad
            // 
            this.txtad.AutoSize = true;
            this.txtad.Location = new System.Drawing.Point(42, 31);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(22, 13);
            this.txtad.TabIndex = 8;
            this.txtad.Text = "ad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.AutoSize = true;
            this.txtsoyad.Location = new System.Drawing.Point(26, 59);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(38, 13);
            this.txtsoyad.TabIndex = 9;
            this.txtsoyad.Text = "soyad:";
            // 
            // txtmaas
            // 
            this.txtmaas.AutoSize = true;
            this.txtmaas.Location = new System.Drawing.Point(29, 110);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(35, 13);
            this.txtmaas.TabIndex = 10;
            this.txtmaas.Text = "maaş:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.txtadres);
            this.groupBox2.Controls.Add(this.txtozgecmıs);
            this.groupBox2.Location = new System.Drawing.Point(403, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 165);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(70, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(73, 19);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 50);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(73, 89);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(229, 49);
            this.textBox5.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "telefon:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(70, 82);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(152, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtkaydet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtadres;
        private System.Windows.Forms.Label txtozgecmıs;
        private System.Windows.Forms.Button txtkaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtmaas;
        private System.Windows.Forms.Label txtad;
        private System.Windows.Forms.Label txtsoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}

