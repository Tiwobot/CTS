namespace coron
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.back = new System.Windows.Forms.PictureBox();
            this.listelink = new System.Windows.Forms.Button();
            this.tcara = new System.Windows.Forms.Button();
            this.zaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.canlık = new System.Windows.Forms.Button();
            this.aratt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(1297, 692);
            this.back.TabIndex = 7;
            this.back.TabStop = false;
            // 
            // listelink
            // 
            this.listelink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.listelink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listelink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listelink.Location = new System.Drawing.Point(563, 166);
            this.listelink.Name = "listelink";
            this.listelink.Size = new System.Drawing.Size(164, 23);
            this.listelink.TabIndex = 8;
            this.listelink.Text = "Kullanıcı Listesi";
            this.listelink.UseVisualStyleBackColor = false;
            this.listelink.Click += new System.EventHandler(this.listelink_Click);
            // 
            // tcara
            // 
            this.tcara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.tcara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tcara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tcara.Location = new System.Drawing.Point(563, 279);
            this.tcara.Name = "tcara";
            this.tcara.Size = new System.Drawing.Size(164, 23);
            this.tcara.TabIndex = 9;
            this.tcara.Text = "TC Kimlik No üzerinden ara";
            this.tcara.UseVisualStyleBackColor = false;
            this.tcara.Click += new System.EventHandler(this.tcara_Click);
            // 
            // zaman
            // 
            this.zaman.AutoSize = true;
            this.zaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.zaman.Font = new System.Drawing.Font("Alte Haas Grotesk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.zaman.Location = new System.Drawing.Point(12, 632);
            this.zaman.Name = "zaman";
            this.zaman.Size = new System.Drawing.Size(94, 26);
            this.zaman.TabIndex = 10;
            this.zaman.Text = "xx/xx/xx";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // canlık
            // 
            this.canlık.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.canlık.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canlık.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.canlık.Location = new System.Drawing.Point(563, 195);
            this.canlık.Name = "canlık";
            this.canlık.Size = new System.Drawing.Size(164, 23);
            this.canlık.TabIndex = 11;
            this.canlık.Text = "Canlı Kullanıcılar";
            this.canlık.UseVisualStyleBackColor = false;
            this.canlık.Click += new System.EventHandler(this.canlık_Click);
            // 
            // aratt
            // 
            this.aratt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.aratt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.aratt.Location = new System.Drawing.Point(563, 250);
            this.aratt.Multiline = true;
            this.aratt.Name = "aratt";
            this.aratt.Size = new System.Drawing.Size(164, 23);
            this.aratt.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(398, 332);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 23);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox2.Location = new System.Drawing.Point(480, 332);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 23);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox3.Location = new System.Drawing.Point(562, 332);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 23);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox4.Location = new System.Drawing.Point(644, 332);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 23);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox5.Location = new System.Drawing.Point(726, 332);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 23);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox6.Location = new System.Drawing.Point(808, 332);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 23);
            this.textBox6.TabIndex = 18;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.aratt);
            this.Controls.Add(this.canlık);
            this.Controls.Add(this.zaman);
            this.Controls.Add(this.tcara);
            this.Controls.Add(this.listelink);
            this.Controls.Add(this.back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "\"CTS\"";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Button listelink;
        private System.Windows.Forms.Button tcara;
        private System.Windows.Forms.Label zaman;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button canlık;
        private System.Windows.Forms.TextBox aratt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}