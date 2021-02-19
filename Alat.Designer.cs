namespace Baze2_MOZAIK
{
    partial class Alat
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
            this.label1 = new System.Windows.Forms.Label();
            this.prikazi_alati = new System.Windows.Forms.Button();
            this.unesi_alati = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.datagrid_alati = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idalata_box = new System.Windows.Forms.TextBox();
            this.nazivalata_box = new System.Windows.Forms.TextBox();
            this.starostalata_box = new System.Windows.Forms.TextBox();
            this.idalataradnika_alat_label = new System.Windows.Forms.Label();
            this.idalataradnika_alat_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_alati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label1.Location = new System.Drawing.Point(360, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALATI";
            // 
            // prikazi_alati
            // 
            this.prikazi_alati.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.prikazi_alati.Location = new System.Drawing.Point(12, 89);
            this.prikazi_alati.Name = "prikazi_alati";
            this.prikazi_alati.Size = new System.Drawing.Size(90, 43);
            this.prikazi_alati.TabIndex = 1;
            this.prikazi_alati.Text = "PRIKAŽI";
            this.prikazi_alati.UseVisualStyleBackColor = false;
            this.prikazi_alati.Click += new System.EventHandler(this.prikazi_alati_Click);
            // 
            // unesi_alati
            // 
            this.unesi_alati.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.unesi_alati.Location = new System.Drawing.Point(108, 89);
            this.unesi_alati.Name = "unesi_alati";
            this.unesi_alati.Size = new System.Drawing.Size(90, 43);
            this.unesi_alati.TabIndex = 2;
            this.unesi_alati.Text = "UNESI";
            this.unesi_alati.UseVisualStyleBackColor = false;
            this.unesi_alati.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Location = new System.Drawing.Point(204, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "UREDI";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Location = new System.Drawing.Point(300, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "IZBRIŠI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // datagrid_alati
            // 
            this.datagrid_alati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_alati.Location = new System.Drawing.Point(407, 89);
            this.datagrid_alati.Name = "datagrid_alati";
            this.datagrid_alati.Size = new System.Drawing.Size(469, 345);
            this.datagrid_alati.TabIndex = 5;
            this.datagrid_alati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_alati_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(171, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID alata:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(142, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Naziv alata:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(132, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Starost alata:";
            // 
            // idalata_box
            // 
            this.idalata_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idalata_box.Location = new System.Drawing.Point(230, 184);
            this.idalata_box.Name = "idalata_box";
            this.idalata_box.Size = new System.Drawing.Size(100, 26);
            this.idalata_box.TabIndex = 9;
            // 
            // nazivalata_box
            // 
            this.nazivalata_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nazivalata_box.Location = new System.Drawing.Point(230, 258);
            this.nazivalata_box.Name = "nazivalata_box";
            this.nazivalata_box.Size = new System.Drawing.Size(100, 26);
            this.nazivalata_box.TabIndex = 10;
            // 
            // starostalata_box
            // 
            this.starostalata_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.starostalata_box.Location = new System.Drawing.Point(230, 329);
            this.starostalata_box.Name = "starostalata_box";
            this.starostalata_box.Size = new System.Drawing.Size(100, 26);
            this.starostalata_box.TabIndex = 11;
            // 
            // idalataradnika_alat_label
            // 
            this.idalataradnika_alat_label.AutoSize = true;
            this.idalataradnika_alat_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idalataradnika_alat_label.Location = new System.Drawing.Point(12, 394);
            this.idalataradnika_alat_label.Name = "idalataradnika_alat_label";
            this.idalataradnika_alat_label.Size = new System.Drawing.Size(219, 17);
            this.idalataradnika_alat_label.TabIndex = 19;
            this.idalataradnika_alat_label.Text = "ID radnika na alatu(neobavezno):";
            // 
            // idalataradnika_alat_box
            // 
            this.idalataradnika_alat_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idalataradnika_alat_box.Location = new System.Drawing.Point(230, 388);
            this.idalataradnika_alat_box.Name = "idalataradnika_alat_box";
            this.idalataradnika_alat_box.Size = new System.Drawing.Size(100, 26);
            this.idalataradnika_alat_box.TabIndex = 20;
            // 
            // Alat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 443);
            this.Controls.Add(this.idalataradnika_alat_box);
            this.Controls.Add(this.idalataradnika_alat_label);
            this.Controls.Add(this.starostalata_box);
            this.Controls.Add(this.nazivalata_box);
            this.Controls.Add(this.idalata_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagrid_alati);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.unesi_alati);
            this.Controls.Add(this.prikazi_alati);
            this.Controls.Add(this.label1);
            this.Name = "Alat";
            this.Text = "Alat";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_alati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prikazi_alati;
        private System.Windows.Forms.Button unesi_alati;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView datagrid_alati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idalata_box;
        private System.Windows.Forms.TextBox nazivalata_box;
        private System.Windows.Forms.TextBox starostalata_box;
        private System.Windows.Forms.Label idalataradnika_alat_label;
        private System.Windows.Forms.TextBox idalataradnika_alat_box;
    }
}