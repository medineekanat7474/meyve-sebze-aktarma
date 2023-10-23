namespace meyve_sebze_aktarma
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
            this.lstyiyecekler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstmeyve = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstsebze = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnaktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstyiyecekler
            // 
            this.lstyiyecekler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstyiyecekler.FormattingEnabled = true;
            this.lstyiyecekler.ItemHeight = 16;
            this.lstyiyecekler.Items.AddRange(new object[] {
            "kiraz",
            "bezelye",
            "marul",
            "ayva",
            "pırasa",
            "karpuz",
            "brokoli",
            "çilek",
            "elma",
            "biber",
            "patlıcan"});
            this.lstyiyecekler.Location = new System.Drawing.Point(25, 64);
            this.lstyiyecekler.Name = "lstyiyecekler";
            this.lstyiyecekler.Size = new System.Drawing.Size(124, 180);
            this.lstyiyecekler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "tüm yiyecekler";
            // 
            // lstmeyve
            // 
            this.lstmeyve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstmeyve.FormattingEnabled = true;
            this.lstmeyve.ItemHeight = 16;
            this.lstmeyve.Location = new System.Drawing.Point(213, 64);
            this.lstmeyve.Name = "lstmeyve";
            this.lstmeyve.Size = new System.Drawing.Size(124, 180);
            this.lstmeyve.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(213, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "meyveler";
            // 
            // lstsebze
            // 
            this.lstsebze.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstsebze.FormattingEnabled = true;
            this.lstsebze.ItemHeight = 16;
            this.lstsebze.Location = new System.Drawing.Point(397, 64);
            this.lstsebze.Name = "lstsebze";
            this.lstsebze.Size = new System.Drawing.Size(124, 180);
            this.lstsebze.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(397, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "sebze";
            // 
            // btnaktar
            // 
            this.btnaktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaktar.Location = new System.Drawing.Point(213, 274);
            this.btnaktar.Name = "btnaktar";
            this.btnaktar.Size = new System.Drawing.Size(124, 55);
            this.btnaktar.TabIndex = 6;
            this.btnaktar.Text = "aktar";
            this.btnaktar.UseVisualStyleBackColor = true;
            this.btnaktar.Click += new System.EventHandler(this.btnaktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 342);
            this.Controls.Add(this.btnaktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstsebze);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstmeyve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstyiyecekler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstyiyecekler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstmeyve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstsebze;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnaktar;
    }
}

