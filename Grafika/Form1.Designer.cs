namespace Grafika
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrCas = new System.Windows.Forms.Timer(this.components);
            this.pbPlatno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDisplay.Location = new System.Drawing.Point(24, 337);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(314, 38);
            this.txtDisplay.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrCas
            // 
            this.tmrCas.Tick += new System.EventHandler(this.tmrCas_Tick);
            // 
            // pbPlatno
            // 
            this.pbPlatno.BackColor = System.Drawing.Color.White;
            this.pbPlatno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPlatno.Location = new System.Drawing.Point(24, 12);
            this.pbPlatno.Name = "pbPlatno";
            this.pbPlatno.Size = new System.Drawing.Size(606, 319);
            this.pbPlatno.TabIndex = 2;
            this.pbPlatno.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 418);
            this.Controls.Add(this.pbPlatno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Testy Grafiky";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrCas;
        private System.Windows.Forms.PictureBox pbPlatno;
    }
}

