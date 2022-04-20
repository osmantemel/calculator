namespace hesap_makinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekranlabel = new System.Windows.Forms.Label();
            this.rakam1button = new System.Windows.Forms.Button();
            this.cbuton = new System.Windows.Forms.Button();
            this.rakam7button = new System.Windows.Forms.Button();
            this.rakam4button = new System.Windows.Forms.Button();
            this.rakam5button = new System.Windows.Forms.Button();
            this.rakam8button = new System.Windows.Forms.Button();
            this.rakam0buton = new System.Windows.Forms.Button();
            this.rakam2button = new System.Windows.Forms.Button();
            this.rakam6button = new System.Windows.Forms.Button();
            this.rakam9button = new System.Windows.Forms.Button();
            this.eşittirbuton = new System.Windows.Forms.Button();
            this.rakam3button = new System.Windows.Forms.Button();
            this.çıkartmabuton = new System.Windows.Forms.Button();
            this.çarpmabuton = new System.Windows.Forms.Button();
            this.bölmebuton = new System.Windows.Forms.Button();
            this.toplamabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekranlabel
            // 
            this.ekranlabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ekranlabel.BackColor = System.Drawing.Color.AliceBlue;
            this.ekranlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.ekranlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranlabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ekranlabel.Location = new System.Drawing.Point(15, 9);
            this.ekranlabel.Name = "ekranlabel";
            this.ekranlabel.Size = new System.Drawing.Size(314, 53);
            this.ekranlabel.TabIndex = 0;
            this.ekranlabel.Text = "0";
            this.ekranlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ekranlabel.Click += new System.EventHandler(this.ekranlabel_Click);
            // 
            // rakam1button
            // 
            this.rakam1button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam1button.Location = new System.Drawing.Point(12, 65);
            this.rakam1button.Name = "rakam1button";
            this.rakam1button.Size = new System.Drawing.Size(75, 75);
            this.rakam1button.TabIndex = 1;
            this.rakam1button.Text = "1";
            this.rakam1button.UseVisualStyleBackColor = false;
            this.rakam1button.Click += new System.EventHandler(this.rakam1button_Click);
            // 
            // cbuton
            // 
            this.cbuton.BackColor = System.Drawing.Color.Orange;
            this.cbuton.Location = new System.Drawing.Point(12, 275);
            this.cbuton.Name = "cbuton";
            this.cbuton.Size = new System.Drawing.Size(75, 75);
            this.cbuton.TabIndex = 3;
            this.cbuton.Text = "C";
            this.cbuton.UseVisualStyleBackColor = false;
            this.cbuton.Click += new System.EventHandler(this.cbuton_Click);
            // 
            // rakam7button
            // 
            this.rakam7button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam7button.Location = new System.Drawing.Point(12, 205);
            this.rakam7button.Name = "rakam7button";
            this.rakam7button.Size = new System.Drawing.Size(75, 75);
            this.rakam7button.TabIndex = 4;
            this.rakam7button.Text = "7";
            this.rakam7button.UseVisualStyleBackColor = false;
            this.rakam7button.Click += new System.EventHandler(this.rakam7button_Click);
            // 
            // rakam4button
            // 
            this.rakam4button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam4button.Location = new System.Drawing.Point(12, 136);
            this.rakam4button.Name = "rakam4button";
            this.rakam4button.Size = new System.Drawing.Size(75, 75);
            this.rakam4button.TabIndex = 7;
            this.rakam4button.Text = "4";
            this.rakam4button.UseVisualStyleBackColor = false;
            this.rakam4button.Click += new System.EventHandler(this.rakam4button_Click);
            // 
            // rakam5button
            // 
            this.rakam5button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam5button.Location = new System.Drawing.Point(93, 136);
            this.rakam5button.Name = "rakam5button";
            this.rakam5button.Size = new System.Drawing.Size(75, 75);
            this.rakam5button.TabIndex = 11;
            this.rakam5button.Text = "5";
            this.rakam5button.UseVisualStyleBackColor = false;
            this.rakam5button.Click += new System.EventHandler(this.rakam5button_Click);
            // 
            // rakam8button
            // 
            this.rakam8button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam8button.Location = new System.Drawing.Point(93, 205);
            this.rakam8button.Name = "rakam8button";
            this.rakam8button.Size = new System.Drawing.Size(75, 75);
            this.rakam8button.TabIndex = 10;
            this.rakam8button.Text = "8";
            this.rakam8button.UseVisualStyleBackColor = false;
            this.rakam8button.Click += new System.EventHandler(this.rakam8button_Click);
            // 
            // rakam0buton
            // 
            this.rakam0buton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam0buton.Location = new System.Drawing.Point(93, 275);
            this.rakam0buton.Name = "rakam0buton";
            this.rakam0buton.Size = new System.Drawing.Size(75, 75);
            this.rakam0buton.TabIndex = 9;
            this.rakam0buton.Text = "0";
            this.rakam0buton.UseVisualStyleBackColor = false;
            this.rakam0buton.Click += new System.EventHandler(this.rakam0buton_Click);
            // 
            // rakam2button
            // 
            this.rakam2button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam2button.Location = new System.Drawing.Point(93, 65);
            this.rakam2button.Name = "rakam2button";
            this.rakam2button.Size = new System.Drawing.Size(75, 75);
            this.rakam2button.TabIndex = 8;
            this.rakam2button.Text = "2";
            this.rakam2button.UseVisualStyleBackColor = false;
            this.rakam2button.Click += new System.EventHandler(this.rakam2button_Click);
            // 
            // rakam6button
            // 
            this.rakam6button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam6button.Location = new System.Drawing.Point(174, 136);
            this.rakam6button.Name = "rakam6button";
            this.rakam6button.Size = new System.Drawing.Size(75, 75);
            this.rakam6button.TabIndex = 15;
            this.rakam6button.Text = "6";
            this.rakam6button.UseVisualStyleBackColor = false;
            this.rakam6button.Click += new System.EventHandler(this.rakam6button_Click);
            // 
            // rakam9button
            // 
            this.rakam9button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam9button.Location = new System.Drawing.Point(174, 205);
            this.rakam9button.Name = "rakam9button";
            this.rakam9button.Size = new System.Drawing.Size(75, 75);
            this.rakam9button.TabIndex = 14;
            this.rakam9button.Text = "9";
            this.rakam9button.UseVisualStyleBackColor = false;
            this.rakam9button.Click += new System.EventHandler(this.rakam9button_Click);
            // 
            // eşittirbuton
            // 
            this.eşittirbuton.BackColor = System.Drawing.Color.Orange;
            this.eşittirbuton.Location = new System.Drawing.Point(174, 275);
            this.eşittirbuton.Name = "eşittirbuton";
            this.eşittirbuton.Size = new System.Drawing.Size(75, 75);
            this.eşittirbuton.TabIndex = 13;
            this.eşittirbuton.Text = "=";
            this.eşittirbuton.UseVisualStyleBackColor = false;
            this.eşittirbuton.Click += new System.EventHandler(this.eşittirbuton_Click);
            // 
            // rakam3button
            // 
            this.rakam3button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rakam3button.Location = new System.Drawing.Point(174, 65);
            this.rakam3button.Name = "rakam3button";
            this.rakam3button.Size = new System.Drawing.Size(75, 75);
            this.rakam3button.TabIndex = 12;
            this.rakam3button.Text = "3";
            this.rakam3button.UseVisualStyleBackColor = false;
            this.rakam3button.Click += new System.EventHandler(this.rakam3button_Click);
            // 
            // çıkartmabuton
            // 
            this.çıkartmabuton.BackColor = System.Drawing.Color.Orange;
            this.çıkartmabuton.Location = new System.Drawing.Point(255, 136);
            this.çıkartmabuton.Name = "çıkartmabuton";
            this.çıkartmabuton.Size = new System.Drawing.Size(75, 75);
            this.çıkartmabuton.TabIndex = 19;
            this.çıkartmabuton.Text = "-";
            this.çıkartmabuton.UseVisualStyleBackColor = false;
            this.çıkartmabuton.Click += new System.EventHandler(this.çıkartmabuton_Click);
            // 
            // çarpmabuton
            // 
            this.çarpmabuton.BackColor = System.Drawing.Color.Orange;
            this.çarpmabuton.Location = new System.Drawing.Point(255, 205);
            this.çarpmabuton.Name = "çarpmabuton";
            this.çarpmabuton.Size = new System.Drawing.Size(75, 75);
            this.çarpmabuton.TabIndex = 18;
            this.çarpmabuton.Text = "*";
            this.çarpmabuton.UseVisualStyleBackColor = false;
            this.çarpmabuton.Click += new System.EventHandler(this.çarpmabuton_Click);
            // 
            // bölmebuton
            // 
            this.bölmebuton.BackColor = System.Drawing.Color.Orange;
            this.bölmebuton.Location = new System.Drawing.Point(255, 275);
            this.bölmebuton.Name = "bölmebuton";
            this.bölmebuton.Size = new System.Drawing.Size(75, 75);
            this.bölmebuton.TabIndex = 17;
            this.bölmebuton.Text = "/";
            this.bölmebuton.UseVisualStyleBackColor = false;
            this.bölmebuton.Click += new System.EventHandler(this.bölmebuton_Click);
            // 
            // toplamabutton
            // 
            this.toplamabutton.BackColor = System.Drawing.Color.Orange;
            this.toplamabutton.Location = new System.Drawing.Point(255, 65);
            this.toplamabutton.Name = "toplamabutton";
            this.toplamabutton.Size = new System.Drawing.Size(75, 75);
            this.toplamabutton.TabIndex = 16;
            this.toplamabutton.Text = "+";
            this.toplamabutton.UseVisualStyleBackColor = false;
            this.toplamabutton.Click += new System.EventHandler(this.toplamabutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(341, 380);
            this.Controls.Add(this.çıkartmabuton);
            this.Controls.Add(this.çarpmabuton);
            this.Controls.Add(this.bölmebuton);
            this.Controls.Add(this.toplamabutton);
            this.Controls.Add(this.rakam6button);
            this.Controls.Add(this.rakam9button);
            this.Controls.Add(this.eşittirbuton);
            this.Controls.Add(this.rakam3button);
            this.Controls.Add(this.rakam5button);
            this.Controls.Add(this.rakam8button);
            this.Controls.Add(this.rakam0buton);
            this.Controls.Add(this.rakam2button);
            this.Controls.Add(this.rakam4button);
            this.Controls.Add(this.rakam7button);
            this.Controls.Add(this.cbuton);
            this.Controls.Add(this.rakam1button);
            this.Controls.Add(this.ekranlabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HESAP MAKİNESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranlabel;
        private System.Windows.Forms.Button rakam1button;
        private System.Windows.Forms.Button cbuton;
        private System.Windows.Forms.Button rakam7button;
        private System.Windows.Forms.Button rakam4button;
        private System.Windows.Forms.Button rakam5button;
        private System.Windows.Forms.Button rakam8button;
        private System.Windows.Forms.Button rakam0buton;
        private System.Windows.Forms.Button rakam2button;
        private System.Windows.Forms.Button rakam6button;
        private System.Windows.Forms.Button rakam9button;
        private System.Windows.Forms.Button eşittirbuton;
        private System.Windows.Forms.Button rakam3button;
        private System.Windows.Forms.Button çıkartmabuton;
        private System.Windows.Forms.Button çarpmabuton;
        private System.Windows.Forms.Button bölmebuton;
        private System.Windows.Forms.Button toplamabutton;
    }
}

