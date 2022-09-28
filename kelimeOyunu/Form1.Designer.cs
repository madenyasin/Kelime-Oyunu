namespace kelimeOyunu


{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSoruEkle = new System.Windows.Forms.TextBox();
            this.labelKelimeOyunu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOyna = new System.Windows.Forms.Button();
            this.txtCevapEkle = new System.Windows.Forms.TextBox();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.lblSoru = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSoruEkle
            // 
            this.txtSoruEkle.Location = new System.Drawing.Point(211, 233);
            this.txtSoruEkle.Name = "txtSoruEkle";
            this.txtSoruEkle.Size = new System.Drawing.Size(441, 27);
            this.txtSoruEkle.TabIndex = 0;
            // 
            // labelKelimeOyunu
            // 
            this.labelKelimeOyunu.AutoSize = true;
            this.labelKelimeOyunu.BackColor = System.Drawing.Color.Transparent;
            this.labelKelimeOyunu.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKelimeOyunu.ForeColor = System.Drawing.Color.White;
            this.labelKelimeOyunu.Location = new System.Drawing.Point(211, 9);
            this.labelKelimeOyunu.Name = "labelKelimeOyunu";
            this.labelKelimeOyunu.Size = new System.Drawing.Size(389, 66);
            this.labelKelimeOyunu.TabIndex = 1;
            this.labelKelimeOyunu.Text = "KELİME OYUNU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-11, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(826, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "--------------------------------------------------------------";
            // 
            // btnOyna
            // 
            this.btnOyna.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOyna.Location = new System.Drawing.Point(275, 99);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(231, 70);
            this.btnOyna.TabIndex = 3;
            this.btnOyna.Text = "OYNA";
            this.btnOyna.UseVisualStyleBackColor = true;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // txtCevapEkle
            // 
            this.txtCevapEkle.Location = new System.Drawing.Point(211, 290);
            this.txtCevapEkle.Name = "txtCevapEkle";
            this.txtCevapEkle.Size = new System.Drawing.Size(441, 27);
            this.txtCevapEkle.TabIndex = 4;
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSoruEkle.Location = new System.Drawing.Point(284, 337);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(213, 68);
            this.btnSoruEkle.TabIndex = 5;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = true;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.BackColor = System.Drawing.Color.Transparent;
            this.lblSoru.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoru.ForeColor = System.Drawing.Color.White;
            this.lblSoru.Location = new System.Drawing.Point(110, 225);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(94, 35);
            this.lblSoru.TabIndex = 6;
            this.lblSoru.Text = "Soru >";
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.BackColor = System.Drawing.Color.Transparent;
            this.lblCevap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCevap.ForeColor = System.Drawing.Color.White;
            this.lblCevap.Location = new System.Drawing.Point(91, 281);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(113, 35);
            this.lblCevap.TabIndex = 7;
            this.lblCevap.Text = "Cevap >";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.btnSoruEkle);
            this.Controls.Add(this.txtCevapEkle);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKelimeOyunu);
            this.Controls.Add(this.txtSoruEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Oyunu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSoruEkle;
        private Label labelKelimeOyunu;
        private Label label2;
        private Button btnOyna;
        private TextBox txtCevapEkle;
        private Button btnSoruEkle;
        private Label lblSoru;
        private Label lblCevap;
    }
}