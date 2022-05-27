namespace ATECH
{
    partial class FrmPregledZahtjeva
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
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.txtPonuditelj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivZahtjeva = new System.Windows.Forms.TextBox();
            this.txtIzvor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPodnositelj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(15, 47);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.Size = new System.Drawing.Size(1062, 511);
            this.dgvZahtjevi.TabIndex = 0;
            this.dgvZahtjevi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZahtjevi_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(1002, 564);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Ažuriraj";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(921, 564);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Izbriši";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(12, 564);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Natrag";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // txtPonuditelj
            // 
            this.txtPonuditelj.Location = new System.Drawing.Point(407, 6);
            this.txtPonuditelj.Multiline = true;
            this.txtPonuditelj.Name = "txtPonuditelj";
            this.txtPonuditelj.Size = new System.Drawing.Size(110, 20);
            this.txtPonuditelj.TabIndex = 4;
            this.txtPonuditelj.TextChanged += new System.EventHandler(this.txtPretraži_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretraži prema ponuditelju:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(807, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pretraži prema nazivu zahtjeva:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNazivZahtjeva
            // 
            this.txtNazivZahtjeva.Location = new System.Drawing.Point(967, 6);
            this.txtNazivZahtjeva.Multiline = true;
            this.txtNazivZahtjeva.Name = "txtNazivZahtjeva";
            this.txtNazivZahtjeva.Size = new System.Drawing.Size(110, 20);
            this.txtNazivZahtjeva.TabIndex = 7;
            this.txtNazivZahtjeva.TextChanged += new System.EventHandler(this.txtNazivZahtjeva_TextChanged);
            // 
            // txtIzvor
            // 
            this.txtIzvor.Location = new System.Drawing.Point(691, 6);
            this.txtIzvor.Multiline = true;
            this.txtIzvor.Name = "txtIzvor";
            this.txtIzvor.Size = new System.Drawing.Size(110, 20);
            this.txtIzvor.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pretraži prema izvoru financiranja:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPodnositelj
            // 
            this.txtPodnositelj.Location = new System.Drawing.Point(154, 6);
            this.txtPodnositelj.Multiline = true;
            this.txtPodnositelj.Name = "txtPodnositelj";
            this.txtPodnositelj.Size = new System.Drawing.Size(110, 20);
            this.txtPodnositelj.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pretraži prema podnositelju:";
            // 
            // FrmPregledZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1087, 601);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPodnositelj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIzvor);
            this.Controls.Add(this.txtNazivZahtjeva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPonuditelj);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvZahtjevi);
            this.Name = "FrmPregledZahtjeva";
            this.Text = "Pregled svih zahtjeva";
            this.Load += new System.EventHandler(this.FrmPregledZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox txtPonuditelj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivZahtjeva;
        private System.Windows.Forms.TextBox txtIzvor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPodnositelj;
        private System.Windows.Forms.Label label4;
    }
}