namespace BankaOtomasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskhesapno = new System.Windows.Forms.MaskedTextBox();
            this.txtsıfre = new System.Windows.Forms.TextBox();
            this.btngırıs = new System.Windows.Forms.Button();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "HESAP NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE:";
            // 
            // mskhesapno
            // 
            this.mskhesapno.Location = new System.Drawing.Point(114, 25);
            this.mskhesapno.Mask = "000000";
            this.mskhesapno.Name = "mskhesapno";
            this.mskhesapno.Size = new System.Drawing.Size(136, 26);
            this.mskhesapno.TabIndex = 1;
            this.mskhesapno.ValidatingType = typeof(int);
            // 
            // txtsıfre
            // 
            this.txtsıfre.Location = new System.Drawing.Point(114, 85);
            this.txtsıfre.Name = "txtsıfre";
            this.txtsıfre.Size = new System.Drawing.Size(136, 26);
            this.txtsıfre.TabIndex = 2;
            this.txtsıfre.UseSystemPasswordChar = true;
            // 
            // btngırıs
            // 
            this.btngırıs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btngırıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngırıs.Image = ((System.Drawing.Image)(resources.GetObject("btngırıs.Image")));
            this.btngırıs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngırıs.Location = new System.Drawing.Point(131, 140);
            this.btngırıs.Name = "btngırıs";
            this.btngırıs.Size = new System.Drawing.Size(119, 35);
            this.btngırıs.TabIndex = 3;
            this.btngırıs.Text = "GİRİŞ";
            this.btngırıs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngırıs.UseVisualStyleBackColor = false;
            this.btngırıs.Click += new System.EventHandler(this.btngırıs_Click);
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncıkıs.Image = ((System.Drawing.Image)(resources.GetObject("btncıkıs.Image")));
            this.btncıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncıkıs.Location = new System.Drawing.Point(12, 140);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(113, 35);
            this.btncıkıs.TabIndex = 4;
            this.btncıkıs.Text = "ÇIKIŞ";
            this.btncıkıs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(459, 202);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btngırıs);
            this.Controls.Add(this.txtsıfre);
            this.Controls.Add(this.mskhesapno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskhesapno;
        private System.Windows.Forms.TextBox txtsıfre;
        private System.Windows.Forms.Button btngırıs;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

