﻿namespace ATECH
{
    partial class FrmPočetna
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
            this.labelKreirajZahtjev = new System.Windows.Forms.Label();
            this.labelPregledajZahtjeve = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.labelOdjava = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKreirajZahtjev
            // 
            this.labelKreirajZahtjev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(78)))));
            this.labelKreirajZahtjev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKreirajZahtjev.ForeColor = System.Drawing.Color.White;
            this.labelKreirajZahtjev.Location = new System.Drawing.Point(12, 123);
            this.labelKreirajZahtjev.Name = "labelKreirajZahtjev";
            this.labelKreirajZahtjev.Size = new System.Drawing.Size(98, 47);
            this.labelKreirajZahtjev.TabIndex = 2;
            this.labelKreirajZahtjev.Text = "Kreiraj zahtjev";
            this.labelKreirajZahtjev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelKreirajZahtjev.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPregledajZahtjeve
            // 
            this.labelPregledajZahtjeve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(78)))));
            this.labelPregledajZahtjeve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPregledajZahtjeve.ForeColor = System.Drawing.Color.White;
            this.labelPregledajZahtjeve.Location = new System.Drawing.Point(12, 190);
            this.labelPregledajZahtjeve.Name = "labelPregledajZahtjeve";
            this.labelPregledajZahtjeve.Size = new System.Drawing.Size(98, 47);
            this.labelPregledajZahtjeve.TabIndex = 4;
            this.labelPregledajZahtjeve.Text = "Pregledaj zahtjeve";
            this.labelPregledajZahtjeve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPregledajZahtjeve.Click += new System.EventHandler(this.labelPregledajZahtjeve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dobrodošli u ATECH";
            //this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(553, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Acquire technical equipment, est. 2022";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ime";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prezime";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mail";
            // 
            // pbx1
            // 
            this.pbx1.Location = new System.Drawing.Point(181, 62);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(410, 295);
            this.pbx1.TabIndex = 10;
            this.pbx1.TabStop = false;
            // 
            // labelOdjava
            // 
            this.labelOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(50)))), ((int)(((byte)(78)))));
            this.labelOdjava.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOdjava.ForeColor = System.Drawing.Color.White;
            this.labelOdjava.Location = new System.Drawing.Point(12, 259);
            this.labelOdjava.Name = "labelOdjava";
            this.labelOdjava.Size = new System.Drawing.Size(98, 47);
            this.labelOdjava.TabIndex = 11;
            this.labelOdjava.Text = "Odjavi se";
            this.labelOdjava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOdjava.Click += new System.EventHandler(this.labelOdjava_Click);
            // 
            // FrmPočetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOdjava);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPregledajZahtjeve);
            this.Controls.Add(this.labelKreirajZahtjev);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmPočetna";
            this.Text = "ATECH";
            this.Load += new System.EventHandler(this.FrmPočetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelKreirajZahtjev;
        private System.Windows.Forms.Label labelPregledajZahtjeve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label labelOdjava;
    }
}

