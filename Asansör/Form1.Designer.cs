
namespace Asansör
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kat5 = new System.Windows.Forms.Button();
            this.kat4 = new System.Windows.Forms.Button();
            this.kat3 = new System.Windows.Forms.Button();
            this.kat2 = new System.Windows.Forms.Button();
            this.kat1 = new System.Windows.Forms.Button();
            this.kat0 = new System.Windows.Forms.Button();
            this.asansör = new System.Windows.Forms.Button();
            this.solkapı = new System.Windows.Forms.Button();
            this.sağkapı = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kapat = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Controls.Add(this.kat5);
            this.groupBox1.Controls.Add(this.kat4);
            this.groupBox1.Controls.Add(this.kat3);
            this.groupBox1.Controls.Add(this.kat2);
            this.groupBox1.Controls.Add(this.kat1);
            this.groupBox1.Controls.Add(this.kat0);
            this.groupBox1.Controls.Add(this.asansör);
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(517, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 546);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BİNA";
            // 
            // kat5
            // 
            this.kat5.BackColor = System.Drawing.Color.DarkRed;
            this.kat5.Location = new System.Drawing.Point(150, 19);
            this.kat5.Name = "kat5";
            this.kat5.Size = new System.Drawing.Size(97, 31);
            this.kat5.TabIndex = 0;
            this.kat5.Text = "KAT 5";
            this.kat5.UseVisualStyleBackColor = false;
            this.kat5.Click += new System.EventHandler(this.kat5_Click);
            // 
            // kat4
            // 
            this.kat4.BackColor = System.Drawing.Color.DarkRed;
            this.kat4.Location = new System.Drawing.Point(150, 99);
            this.kat4.Name = "kat4";
            this.kat4.Size = new System.Drawing.Size(97, 31);
            this.kat4.TabIndex = 0;
            this.kat4.Text = "KAT 4";
            this.kat4.UseVisualStyleBackColor = false;
            this.kat4.Click += new System.EventHandler(this.kat4_Click);
            // 
            // kat3
            // 
            this.kat3.BackColor = System.Drawing.Color.DarkRed;
            this.kat3.Location = new System.Drawing.Point(150, 199);
            this.kat3.Name = "kat3";
            this.kat3.Size = new System.Drawing.Size(97, 31);
            this.kat3.TabIndex = 0;
            this.kat3.Text = "KAT 3";
            this.kat3.UseVisualStyleBackColor = false;
            this.kat3.Click += new System.EventHandler(this.kat3_Click);
            // 
            // kat2
            // 
            this.kat2.BackColor = System.Drawing.Color.DarkRed;
            this.kat2.Location = new System.Drawing.Point(150, 299);
            this.kat2.Name = "kat2";
            this.kat2.Size = new System.Drawing.Size(97, 31);
            this.kat2.TabIndex = 0;
            this.kat2.Text = "KAT 2";
            this.kat2.UseVisualStyleBackColor = false;
            this.kat2.Click += new System.EventHandler(this.kat2_Click);
            // 
            // kat1
            // 
            this.kat1.BackColor = System.Drawing.Color.DarkRed;
            this.kat1.Location = new System.Drawing.Point(150, 399);
            this.kat1.Name = "kat1";
            this.kat1.Size = new System.Drawing.Size(97, 31);
            this.kat1.TabIndex = 0;
            this.kat1.Text = "KAT 1";
            this.kat1.UseVisualStyleBackColor = false;
            this.kat1.Click += new System.EventHandler(this.kat1_Click);
            // 
            // kat0
            // 
            this.kat0.BackColor = System.Drawing.Color.DarkRed;
            this.kat0.Location = new System.Drawing.Point(150, 499);
            this.kat0.Name = "kat0";
            this.kat0.Size = new System.Drawing.Size(97, 31);
            this.kat0.TabIndex = 0;
            this.kat0.Text = "KAT 0";
            this.kat0.UseVisualStyleBackColor = false;
            this.kat0.Click += new System.EventHandler(this.kat0_Click);
            // 
            // asansör
            // 
            this.asansör.BackColor = System.Drawing.Color.DarkBlue;
            this.asansör.Location = new System.Drawing.Point(10, 501);
            this.asansör.Name = "asansör";
            this.asansör.Size = new System.Drawing.Size(130, 29);
            this.asansör.TabIndex = 0;
            this.asansör.Text = "ASANSÖR";
            this.asansör.UseVisualStyleBackColor = false;
            // 
            // solkapı
            // 
            this.solkapı.BackColor = System.Drawing.Color.DarkCyan;
            this.solkapı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.solkapı.Image = ((System.Drawing.Image)(resources.GetObject("solkapı.Image")));
            this.solkapı.Location = new System.Drawing.Point(120, 171);
            this.solkapı.Name = "solkapı";
            this.solkapı.Size = new System.Drawing.Size(129, 189);
            this.solkapı.TabIndex = 1;
            this.solkapı.UseVisualStyleBackColor = false;
            // 
            // sağkapı
            // 
            this.sağkapı.BackColor = System.Drawing.Color.DarkCyan;
            this.sağkapı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sağkapı.Image = ((System.Drawing.Image)(resources.GetObject("sağkapı.Image")));
            this.sağkapı.Location = new System.Drawing.Point(250, 171);
            this.sağkapı.Name = "sağkapı";
            this.sağkapı.Size = new System.Drawing.Size(129, 189);
            this.sağkapı.TabIndex = 1;
            this.sağkapı.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(41, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Location = new System.Drawing.Point(200, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 31);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KAT";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 189);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.kapat);
            this.groupBox3.Controls.Add(this.ac);
            this.groupBox3.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox3.Location = new System.Drawing.Point(325, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 109);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kapı kontrol";
            // 
            // kapat
            // 
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kapat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kapat.Location = new System.Drawing.Point(91, 36);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(85, 57);
            this.kapat.TabIndex = 0;
            this.kapat.Text = "> < KAPAT";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.button2_Click);
            // 
            // ac
            // 
            this.ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ac.Location = new System.Drawing.Point(6, 36);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(85, 57);
            this.ac.TabIndex = 0;
            this.ac.Text = "  < >    AÇ";
            this.ac.UseVisualStyleBackColor = true;
            this.ac.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(801, 588);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sağkapı);
            this.Controls.Add(this.solkapı);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "BAYRAM İMRAN KÜÇÜK";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button kat5;
        private System.Windows.Forms.Button kat4;
        private System.Windows.Forms.Button kat3;
        private System.Windows.Forms.Button kat2;
        private System.Windows.Forms.Button kat1;
        private System.Windows.Forms.Button kat0;
        private System.Windows.Forms.Button asansör;
        private System.Windows.Forms.Button solkapı;
        private System.Windows.Forms.Button sağkapı;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button ac;
    }
}

