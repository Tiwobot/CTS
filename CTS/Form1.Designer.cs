namespace coron
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tckm = new System.Windows.Forms.TextBox();
            this.tcksif = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.yetkfoto = new System.Windows.Forms.PictureBox();
            this.yetkgiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hesapac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1359, 710);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tckm
            // 
            this.tckm.Location = new System.Drawing.Point(519, 201);
            this.tckm.Name = "tckm";
            this.tckm.Size = new System.Drawing.Size(374, 20);
            this.tckm.TabIndex = 1;
            // 
            // tcksif
            // 
            this.tcksif.Location = new System.Drawing.Point(519, 228);
            this.tcksif.Name = "tcksif";
            this.tcksif.PasswordChar = '*';
            this.tcksif.Size = new System.Drawing.Size(374, 20);
            this.tcksif.TabIndex = 2;
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.SystemColors.Info;
            this.giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris.Font = new System.Drawing.Font("Alte Haas Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giris.ForeColor = System.Drawing.Color.Maroon;
            this.giris.Location = new System.Drawing.Point(565, 269);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(105, 37);
            this.giris.TabIndex = 3;
            this.giris.Text = "\"GİRİŞ\"";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Purple;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.linkLabel1.Font = new System.Drawing.Font("Alte Haas Grotesk", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.linkLabel1.Location = new System.Drawing.Point(1031, 228);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 16);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click Me";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Alte Haas Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(536, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "\"YETKİLİ GİRİŞ\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // yetkfoto
            // 
            this.yetkfoto.Image = ((System.Drawing.Image)(resources.GetObject("yetkfoto.Image")));
            this.yetkfoto.Location = new System.Drawing.Point(0, 0);
            this.yetkfoto.Name = "yetkfoto";
            this.yetkfoto.Size = new System.Drawing.Size(1297, 692);
            this.yetkfoto.TabIndex = 6;
            this.yetkfoto.TabStop = false;
            // 
            // yetkgiris
            // 
            this.yetkgiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.yetkgiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yetkgiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yetkgiris.Font = new System.Drawing.Font("Alte Haas Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yetkgiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.yetkgiris.Location = new System.Drawing.Point(565, 269);
            this.yetkgiris.Name = "yetkgiris";
            this.yetkgiris.Size = new System.Drawing.Size(105, 37);
            this.yetkgiris.TabIndex = 7;
            this.yetkgiris.Text = "\"GİRİŞ\"";
            this.yetkgiris.UseVisualStyleBackColor = false;
            this.yetkgiris.Click += new System.EventHandler(this.yetkgiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Alte Haas Grotesk", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(536, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "\"NORMAL GİRİŞ\"";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hesapac
            // 
            this.hesapac.AutoSize = true;
            this.hesapac.BackColor = System.Drawing.SystemColors.Info;
            this.hesapac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hesapac.Font = new System.Drawing.Font("Alte Haas Grotesk", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hesapac.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.hesapac.Location = new System.Drawing.Point(563, 309);
            this.hesapac.Name = "hesapac";
            this.hesapac.Size = new System.Drawing.Size(107, 16);
            this.hesapac.TabIndex = 10;
            this.hesapac.Text = "\"hesap oluştur\"";
            this.hesapac.Click += new System.EventHandler(this.hesapac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.hesapac);
            this.Controls.Add(this.tcksif);
            this.Controls.Add(this.tckm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yetkgiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.yetkfoto);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "\"CTS\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tckm;
        private System.Windows.Forms.TextBox tcksif;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox yetkfoto;
        private System.Windows.Forms.Button yetkgiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hesapac;
    }
}

