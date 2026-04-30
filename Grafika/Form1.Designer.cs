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
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDisplay.Location = new System.Drawing.Point(24, 192);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(314, 38);
            this.txtDisplay.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrCas
            // 
            this.tmrCas.Tick += new System.EventHandler(this.tmrCas_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Testy Grafiky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrCas;
    }
}

