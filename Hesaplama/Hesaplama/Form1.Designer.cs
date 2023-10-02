namespace Hesaplama
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
            this.lblAlıs = new System.Windows.Forms.Label();
            this.txtSatıs = new System.Windows.Forms.Label();
            this.btnHesapala = new System.Windows.Forms.Button();
            this.txtAlisfiyati = new System.Windows.Forms.TextBox();
            this.txtSatisfiyati = new System.Windows.Forms.TextBox();
            this.lblToplamkar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAlıs
            // 
            this.lblAlıs.AutoSize = true;
            this.lblAlıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlıs.Location = new System.Drawing.Point(66, 63);
            this.lblAlıs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlıs.Name = "lblAlıs";
            this.lblAlıs.Size = new System.Drawing.Size(75, 16);
            this.lblAlıs.TabIndex = 0;
            this.lblAlıs.Text = "Alış Fiyatı";
            // 
            // txtSatıs
            // 
            this.txtSatıs.AutoSize = true;
            this.txtSatıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatıs.Location = new System.Drawing.Point(66, 98);
            this.txtSatıs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSatıs.Name = "txtSatıs";
            this.txtSatıs.Size = new System.Drawing.Size(84, 16);
            this.txtSatıs.TabIndex = 1;
            this.txtSatıs.Text = "Satış Fiyatı";
            // 
            // btnHesapala
            // 
            this.btnHesapala.BackColor = System.Drawing.Color.Gold;
            this.btnHesapala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapala.Location = new System.Drawing.Point(201, 129);
            this.btnHesapala.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHesapala.Name = "btnHesapala";
            this.btnHesapala.Size = new System.Drawing.Size(188, 49);
            this.btnHesapala.TabIndex = 2;
            this.btnHesapala.Text = "Kar Hsapla";
            this.btnHesapala.UseVisualStyleBackColor = false;
            this.btnHesapala.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAlisfiyati
            // 
            this.txtAlisfiyati.Location = new System.Drawing.Point(201, 65);
            this.txtAlisfiyati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlisfiyati.Name = "txtAlisfiyati";
            this.txtAlisfiyati.Size = new System.Drawing.Size(186, 22);
            this.txtAlisfiyati.TabIndex = 3;
            // 
            // txtSatisfiyati
            // 
            this.txtSatisfiyati.Location = new System.Drawing.Point(201, 97);
            this.txtSatisfiyati.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSatisfiyati.Name = "txtSatisfiyati";
            this.txtSatisfiyati.Size = new System.Drawing.Size(186, 22);
            this.txtSatisfiyati.TabIndex = 4;
            // 
            // lblToplamkar
            // 
            this.lblToplamkar.AutoSize = true;
            this.lblToplamkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamkar.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblToplamkar.Location = new System.Drawing.Point(106, 236);
            this.lblToplamkar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamkar.Name = "lblToplamkar";
            this.lblToplamkar.Size = new System.Drawing.Size(91, 16);
            this.lblToplamkar.TabIndex = 5;
            this.lblToplamkar.Text = "Toplam Kar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(457, 281);
            this.Controls.Add(this.lblToplamkar);
            this.Controls.Add(this.txtSatisfiyati);
            this.Controls.Add(this.txtAlisfiyati);
            this.Controls.Add(this.btnHesapala);
            this.Controls.Add(this.txtSatıs);
            this.Controls.Add(this.lblAlıs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kar Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlıs;
        private System.Windows.Forms.Label txtSatıs;
        private System.Windows.Forms.Button btnHesapala;
        private System.Windows.Forms.TextBox txtAlisfiyati;
        private System.Windows.Forms.TextBox txtSatisfiyati;
        private System.Windows.Forms.Label lblToplamkar;
    }
}

