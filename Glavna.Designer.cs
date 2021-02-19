namespace Baze2_MOZAIK
{
    partial class Glavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ALATI = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.label2.Location = new System.Drawing.Point(431, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "TABLICE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(302, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 63);
            this.label1.TabIndex = 15;
            this.label1.Text = "MOZAIK D.O.O.\r\n";
            // 
            // ALATI
            // 
            this.ALATI.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ALATI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.ALATI.Location = new System.Drawing.Point(275, 373);
            this.ALATI.Name = "ALATI";
            this.ALATI.Size = new System.Drawing.Size(118, 61);
            this.ALATI.TabIndex = 17;
            this.ALATI.Text = "ALATI";
            this.ALATI.UseVisualStyleBackColor = false;
            this.ALATI.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(437, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 61);
            this.button2.TabIndex = 18;
            this.button2.Text = "RADNICI";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(609, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 61);
            this.button3.TabIndex = 19;
            this.button3.Text = "RADNICI NA ALATIMA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(755, 99);
            this.label3.TabIndex = 20;
            this.label3.Text = "APLIKACIJA ZA UNOŠENJE, PREGLEDAVANJE, \r\nUREĐIVANJE I BRISANJE ZAPISA IZ BAZE POD" +
    "ATAKA\r\n\r\n";
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(997, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ALATI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Glavna";
            this.Text = "Glavna forma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ALATI;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}

