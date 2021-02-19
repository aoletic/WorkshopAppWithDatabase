namespace Baze2_MOZAIK
{
    partial class Radnici
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
            this.label_naslov_radnici = new System.Windows.Forms.Label();
            this.prikazi_radnici = new System.Windows.Forms.Button();
            this.unesi_radnici = new System.Windows.Forms.Button();
            this.uredi_radnici = new System.Windows.Forms.Button();
            this.izbrisi_radnici = new System.Windows.Forms.Button();
            this.oib_radnika_label = new System.Windows.Forms.Label();
            this.prez_ime_radnika_label = new System.Windows.Forms.Label();
            this.datum_rodenja_radnici_label = new System.Windows.Forms.Label();
            this.staz_radnici_label = new System.Windows.Forms.Label();
            this.oibradnici_box = new System.Windows.Forms.TextBox();
            this.prez_ime_box = new System.Windows.Forms.TextBox();
            this.datum_rodenja_box = new System.Windows.Forms.TextBox();
            this.godine_staza_box = new System.Windows.Forms.TextBox();
            this.datagrid_radnici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_radnici)).BeginInit();
            this.SuspendLayout();
            // 
            // label_naslov_radnici
            // 
            this.label_naslov_radnici.AutoSize = true;
            this.label_naslov_radnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label_naslov_radnici.Location = new System.Drawing.Point(350, 30);
            this.label_naslov_radnici.Name = "label_naslov_radnici";
            this.label_naslov_radnici.Size = new System.Drawing.Size(134, 33);
            this.label_naslov_radnici.TabIndex = 0;
            this.label_naslov_radnici.Text = "RADNICI";
            // 
            // prikazi_radnici
            // 
            this.prikazi_radnici.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.prikazi_radnici.Location = new System.Drawing.Point(12, 89);
            this.prikazi_radnici.Name = "prikazi_radnici";
            this.prikazi_radnici.Size = new System.Drawing.Size(90, 43);
            this.prikazi_radnici.TabIndex = 2;
            this.prikazi_radnici.Text = "PRIKAŽI";
            this.prikazi_radnici.UseVisualStyleBackColor = false;
            this.prikazi_radnici.Click += new System.EventHandler(this.prikazi_radnici_Click);
            // 
            // unesi_radnici
            // 
            this.unesi_radnici.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.unesi_radnici.Location = new System.Drawing.Point(108, 89);
            this.unesi_radnici.Name = "unesi_radnici";
            this.unesi_radnici.Size = new System.Drawing.Size(90, 43);
            this.unesi_radnici.TabIndex = 3;
            this.unesi_radnici.Text = "UNESI";
            this.unesi_radnici.UseVisualStyleBackColor = false;
            this.unesi_radnici.Click += new System.EventHandler(this.unesi_radnici_Click);
            // 
            // uredi_radnici
            // 
            this.uredi_radnici.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.uredi_radnici.Location = new System.Drawing.Point(204, 89);
            this.uredi_radnici.Name = "uredi_radnici";
            this.uredi_radnici.Size = new System.Drawing.Size(90, 43);
            this.uredi_radnici.TabIndex = 4;
            this.uredi_radnici.Text = "UREDI";
            this.uredi_radnici.UseVisualStyleBackColor = false;
            this.uredi_radnici.Click += new System.EventHandler(this.uredi_radnici_Click);
            // 
            // izbrisi_radnici
            // 
            this.izbrisi_radnici.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.izbrisi_radnici.Location = new System.Drawing.Point(300, 89);
            this.izbrisi_radnici.Name = "izbrisi_radnici";
            this.izbrisi_radnici.Size = new System.Drawing.Size(90, 43);
            this.izbrisi_radnici.TabIndex = 5;
            this.izbrisi_radnici.Text = "IZBRIŠI";
            this.izbrisi_radnici.UseVisualStyleBackColor = false;
            this.izbrisi_radnici.Click += new System.EventHandler(this.izbrisi_radnici_Click);
            // 
            // oib_radnika_label
            // 
            this.oib_radnika_label.AutoSize = true;
            this.oib_radnika_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.oib_radnika_label.Location = new System.Drawing.Point(41, 178);
            this.oib_radnika_label.Name = "oib_radnika_label";
            this.oib_radnika_label.Size = new System.Drawing.Size(167, 17);
            this.oib_radnika_label.TabIndex = 7;
            this.oib_radnika_label.Text = "OIB radnika (11 brojeva):";
            // 
            // prez_ime_radnika_label
            // 
            this.prez_ime_radnika_label.AutoSize = true;
            this.prez_ime_radnika_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.prez_ime_radnika_label.Location = new System.Drawing.Point(62, 242);
            this.prez_ime_radnika_label.Name = "prez_ime_radnika_label";
            this.prez_ime_radnika_label.Size = new System.Drawing.Size(146, 17);
            this.prez_ime_radnika_label.TabIndex = 8;
            this.prez_ime_radnika_label.Text = "Ime i prezime radnika:";
            // 
            // datum_rodenja_radnici_label
            // 
            this.datum_rodenja_radnici_label.AutoSize = true;
            this.datum_rodenja_radnici_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.datum_rodenja_radnici_label.Location = new System.Drawing.Point(1, 299);
            this.datum_rodenja_radnici_label.Name = "datum_rodenja_radnici_label";
            this.datum_rodenja_radnici_label.Size = new System.Drawing.Size(207, 17);
            this.datum_rodenja_radnici_label.TabIndex = 9;
            this.datum_rodenja_radnici_label.Text = "Datum rođenja (YYYY-MM-DD):";
            // 
            // staz_radnici_label
            // 
            this.staz_radnici_label.AutoSize = true;
            this.staz_radnici_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.staz_radnici_label.Location = new System.Drawing.Point(63, 353);
            this.staz_radnici_label.Name = "staz_radnici_label";
            this.staz_radnici_label.Size = new System.Drawing.Size(145, 17);
            this.staz_radnici_label.TabIndex = 10;
            this.staz_radnici_label.Text = "Godine radnog staža:";
            // 
            // oibradnici_box
            // 
            this.oibradnici_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.oibradnici_box.Location = new System.Drawing.Point(214, 172);
            this.oibradnici_box.Name = "oibradnici_box";
            this.oibradnici_box.Size = new System.Drawing.Size(137, 26);
            this.oibradnici_box.TabIndex = 11;
            // 
            // prez_ime_box
            // 
            this.prez_ime_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.prez_ime_box.Location = new System.Drawing.Point(214, 236);
            this.prez_ime_box.Name = "prez_ime_box";
            this.prez_ime_box.Size = new System.Drawing.Size(137, 26);
            this.prez_ime_box.TabIndex = 12;
            // 
            // datum_rodenja_box
            // 
            this.datum_rodenja_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datum_rodenja_box.Location = new System.Drawing.Point(214, 293);
            this.datum_rodenja_box.Name = "datum_rodenja_box";
            this.datum_rodenja_box.Size = new System.Drawing.Size(137, 26);
            this.datum_rodenja_box.TabIndex = 13;
            // 
            // godine_staza_box
            // 
            this.godine_staza_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.godine_staza_box.Location = new System.Drawing.Point(214, 347);
            this.godine_staza_box.Name = "godine_staza_box";
            this.godine_staza_box.Size = new System.Drawing.Size(137, 26);
            this.godine_staza_box.TabIndex = 14;
            // 
            // datagrid_radnici
            // 
            this.datagrid_radnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_radnici.Location = new System.Drawing.Point(403, 89);
            this.datagrid_radnici.Name = "datagrid_radnici";
            this.datagrid_radnici.Size = new System.Drawing.Size(477, 345);
            this.datagrid_radnici.TabIndex = 15;
            // 
            // Radnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 443);
            this.Controls.Add(this.datagrid_radnici);
            this.Controls.Add(this.godine_staza_box);
            this.Controls.Add(this.datum_rodenja_box);
            this.Controls.Add(this.prez_ime_box);
            this.Controls.Add(this.oibradnici_box);
            this.Controls.Add(this.staz_radnici_label);
            this.Controls.Add(this.datum_rodenja_radnici_label);
            this.Controls.Add(this.prez_ime_radnika_label);
            this.Controls.Add(this.oib_radnika_label);
            this.Controls.Add(this.izbrisi_radnici);
            this.Controls.Add(this.uredi_radnici);
            this.Controls.Add(this.unesi_radnici);
            this.Controls.Add(this.prikazi_radnici);
            this.Controls.Add(this.label_naslov_radnici);
            this.Name = "Radnici";
            this.Text = "Radnici";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_radnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_naslov_radnici;
        private System.Windows.Forms.Button prikazi_radnici;
        private System.Windows.Forms.Button unesi_radnici;
        private System.Windows.Forms.Button uredi_radnici;
        private System.Windows.Forms.Button izbrisi_radnici;
        private System.Windows.Forms.Label oib_radnika_label;
        private System.Windows.Forms.Label prez_ime_radnika_label;
        private System.Windows.Forms.Label datum_rodenja_radnici_label;
        private System.Windows.Forms.Label staz_radnici_label;
        private System.Windows.Forms.TextBox oibradnici_box;
        private System.Windows.Forms.TextBox prez_ime_box;
        private System.Windows.Forms.TextBox datum_rodenja_box;
        private System.Windows.Forms.TextBox godine_staza_box;
        private System.Windows.Forms.DataGridView datagrid_radnici;
    }
}