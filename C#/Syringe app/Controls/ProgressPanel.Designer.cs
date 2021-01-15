namespace Syringe_app
{
    partial class ProgressPanel
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.time_elapsed_txt = new System.Windows.Forms.Label();
            this.injected = new System.Windows.Forms.TextBox();
            this.pumped = new System.Windows.Forms.TextBox();
            this.run_status = new System.Windows.Forms.TextBox();
            this.syringe_pict = new System.Windows.Forms.PictureBox();
            this.progress_bar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.syringe_pict)).BeginInit();
            this.SuspendLayout();
            // 
            // time_elapsed_txt
            // 
            this.time_elapsed_txt.AutoSize = true;
            this.time_elapsed_txt.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.time_elapsed_txt.Location = new System.Drawing.Point(198, 19);
            this.time_elapsed_txt.Name = "time_elapsed_txt";
            this.time_elapsed_txt.Size = new System.Drawing.Size(231, 16);
            this.time_elapsed_txt.TabIndex = 15;
            this.time_elapsed_txt.Text = "Elapsed time: 0h:00m:00s:000ms";
            // 
            // injected
            // 
            this.injected.BackColor = System.Drawing.Color.White;
            this.injected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.injected.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.injected.Location = new System.Drawing.Point(113, 285);
            this.injected.Multiline = true;
            this.injected.Name = "injected";
            this.injected.ReadOnly = true;
            this.injected.Size = new System.Drawing.Size(269, 20);
            this.injected.TabIndex = 35;
            this.injected.TabStop = false;
            this.injected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pumped
            // 
            this.pumped.BackColor = System.Drawing.Color.White;
            this.pumped.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pumped.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.pumped.Location = new System.Drawing.Point(167, 263);
            this.pumped.Name = "pumped";
            this.pumped.ReadOnly = true;
            this.pumped.Size = new System.Drawing.Size(165, 16);
            this.pumped.TabIndex = 33;
            this.pumped.TabStop = false;
            this.pumped.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // run_status
            // 
            this.run_status.BackColor = System.Drawing.Color.White;
            this.run_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.run_status.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.run_status.Location = new System.Drawing.Point(6, 205);
            this.run_status.Multiline = true;
            this.run_status.Name = "run_status";
            this.run_status.ReadOnly = true;
            this.run_status.Size = new System.Drawing.Size(265, 20);
            this.run_status.TabIndex = 10;
            this.run_status.TabStop = false;
            // 
            // syringe_pict
            // 
            this.syringe_pict.Location = new System.Drawing.Point(3, 3);
            this.syringe_pict.Name = "syringe_pict";
            this.syringe_pict.Size = new System.Drawing.Size(422, 226);
            this.syringe_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.syringe_pict.TabIndex = 12;
            this.syringe_pict.TabStop = false;
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(4, 235);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(422, 22);
            this.progress_bar.TabIndex = 14;
            // 
            // ProgressPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.time_elapsed_txt);
            this.Controls.Add(this.injected);
            this.Controls.Add(this.pumped);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.run_status);
            this.Controls.Add(this.syringe_pict);
            this.Name = "ProgressPanel";
            this.Size = new System.Drawing.Size(429, 317);
            ((System.ComponentModel.ISupportInitialize)(this.syringe_pict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_elapsed_txt;
        private System.Windows.Forms.TextBox injected;
        private System.Windows.Forms.TextBox pumped;
        private System.Windows.Forms.TextBox run_status;
        private System.Windows.Forms.PictureBox syringe_pict;
        private System.Windows.Forms.Panel progress_bar;
    }
}
