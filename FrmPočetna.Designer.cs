namespace ATECH
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
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelKreirajZahtjev = new System.Windows.Forms.Label();
            this.dgvKorisnik = new System.Windows.Forms.DataGridView();
            this.labelPregledajZahtjeve = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnik)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(112, 451);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Početna stranica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelKreirajZahtjev
            // 
            this.labelKreirajZahtjev.AutoSize = true;
            this.labelKreirajZahtjev.BackColor = System.Drawing.Color.White;
            this.labelKreirajZahtjev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelKreirajZahtjev.Location = new System.Drawing.Point(12, 72);
            this.labelKreirajZahtjev.Name = "labelKreirajZahtjev";
            this.labelKreirajZahtjev.Size = new System.Drawing.Size(75, 15);
            this.labelKreirajZahtjev.TabIndex = 2;
            this.labelKreirajZahtjev.Text = "Kreiraj zahtjev";
            this.labelKreirajZahtjev.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvKorisnik
            // 
            this.dgvKorisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnik.Location = new System.Drawing.Point(118, 107);
            this.dgvKorisnik.Name = "dgvKorisnik";
            this.dgvKorisnik.Size = new System.Drawing.Size(670, 219);
            this.dgvKorisnik.TabIndex = 3;
            // 
            // labelPregledajZahtjeve
            // 
            this.labelPregledajZahtjeve.AutoSize = true;
            this.labelPregledajZahtjeve.BackColor = System.Drawing.Color.White;
            this.labelPregledajZahtjeve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPregledajZahtjeve.Location = new System.Drawing.Point(12, 125);
            this.labelPregledajZahtjeve.Name = "labelPregledajZahtjeve";
            this.labelPregledajZahtjeve.Size = new System.Drawing.Size(96, 15);
            this.labelPregledajZahtjeve.TabIndex = 4;
            this.labelPregledajZahtjeve.Text = "Pregledaj zahtjeve";
            this.labelPregledajZahtjeve.Click += new System.EventHandler(this.labelPregledajZahtjeve_Click);
            // 
            // FrmPočetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPregledajZahtjeve);
            this.Controls.Add(this.dgvKorisnik);
            this.Controls.Add(this.labelKreirajZahtjev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmPočetna";
            this.Text = "ATECH";
            this.Load += new System.EventHandler(this.FrmPočetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelKreirajZahtjev;
        private System.Windows.Forms.DataGridView dgvKorisnik;
        private System.Windows.Forms.Label labelPregledajZahtjeve;
    }
}

