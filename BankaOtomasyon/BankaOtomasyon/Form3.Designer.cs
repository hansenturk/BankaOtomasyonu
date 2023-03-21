namespace BankaOtomasyon
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskhesapno = new System.Windows.Forms.MaskedTextBox();
            this.txtsıfre = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnhesapno = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnresim = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "AD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC KİMLİK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "HESAP NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "ŞİFRE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "TELEFON:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(116, 25);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(152, 26);
            this.txtad.TabIndex = 1;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(116, 101);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(152, 26);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(116, 62);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(152, 26);
            this.txtsoyad.TabIndex = 2;
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(116, 138);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(152, 26);
            this.msktelefon.TabIndex = 4;
            // 
            // mskhesapno
            // 
            this.mskhesapno.Cursor = System.Windows.Forms.Cursors.No;
            this.mskhesapno.Enabled = false;
            this.mskhesapno.Location = new System.Drawing.Point(116, 177);
            this.mskhesapno.Mask = "000000";
            this.mskhesapno.Name = "mskhesapno";
            this.mskhesapno.Size = new System.Drawing.Size(152, 26);
            this.mskhesapno.TabIndex = 5;
            this.mskhesapno.ValidatingType = typeof(int);
            // 
            // txtsıfre
            // 
            this.txtsıfre.Location = new System.Drawing.Point(116, 218);
            this.txtsıfre.Name = "txtsıfre";
            this.txtsıfre.Size = new System.Drawing.Size(152, 26);
            this.txtsıfre.TabIndex = 6;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.Image")));
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydet.Location = new System.Drawing.Point(116, 261);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(152, 37);
            this.btnkaydet.TabIndex = 7;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnhesapno
            // 
            this.btnhesapno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhesapno.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhesapno.Image = ((System.Drawing.Image)(resources.GetObject("btnhesapno.Image")));
            this.btnhesapno.Location = new System.Drawing.Point(274, 180);
            this.btnhesapno.Name = "btnhesapno";
            this.btnhesapno.Size = new System.Drawing.Size(29, 22);
            this.btnhesapno.TabIndex = 8;
            this.btnhesapno.UseVisualStyleBackColor = true;
            this.btnhesapno.Click += new System.EventHandler(this.btnhesapno_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncıkıs.Image = ((System.Drawing.Image)(resources.GetObject("btncıkıs.Image")));
            this.btncıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncıkıs.Location = new System.Drawing.Point(12, 261);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(92, 37);
            this.btncıkıs.TabIndex = 11;
            this.btncıkıs.Text = "ÇIKIŞ  ";
            this.btncıkıs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnresim
            // 
            this.btnresim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnresim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnresim.Location = new System.Drawing.Point(286, 142);
            this.btnresim.Name = "btnresim";
            this.btnresim.Size = new System.Drawing.Size(110, 26);
            this.btnresim.TabIndex = 13;
            this.btnresim.Text = "Resim Ekle";
            this.btnresim.UseVisualStyleBackColor = false;
            this.btnresim.Click += new System.EventHandler(this.btnresim_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(298, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 310);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnresim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btnhesapno);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtsıfre);
            this.Controls.Add(this.mskhesapno);
            this.Controls.Add(this.msktelefon);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAYIT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.MaskedTextBox mskhesapno;
        private System.Windows.Forms.TextBox txtsıfre;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnhesapno;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnresim;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}