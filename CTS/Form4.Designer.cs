namespace coron
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.genelarayuz = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.genelarayuz)).BeginInit();
            this.SuspendLayout();
            // 
            // genelarayuz
            // 
            this.genelarayuz.Image = ((System.Drawing.Image)(resources.GetObject("genelarayuz.Image")));
            this.genelarayuz.Location = new System.Drawing.Point(0, 0);
            this.genelarayuz.Name = "genelarayuz";
            this.genelarayuz.Size = new System.Drawing.Size(1280, 720);
            this.genelarayuz.TabIndex = 12;
            this.genelarayuz.TabStop = false;
            this.genelarayuz.Click += new System.EventHandler(this.genelarayuz_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.Info;
            this.info.Font = new System.Drawing.Font("Alte Haas Grotesk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.info.Location = new System.Drawing.Point(575, 282);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(122, 40);
            this.info.TabIndex = 13;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Alte Haas Grotesk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(522, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Risk düzeyiniz 100 üzerinden:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Alte Haas Grotesk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(484, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 150);
            this.button1.TabIndex = 15;
            this.button1.Text = "\"Soruları Başlat\"";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.genelarayuz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "\"CTS\"";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genelarayuz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox genelarayuz;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}