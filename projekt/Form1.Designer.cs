namespace projekt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnPIL = new System.Windows.Forms.Button();
            this.btnScannen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(-6, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 199);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flughafen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckIn.Location = new System.Drawing.Point(3, 203);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(240, 163);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnPIL
            // 
            this.btnPIL.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPIL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPIL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPIL.Location = new System.Drawing.Point(249, 203);
            this.btnPIL.Name = "btnPIL";
            this.btnPIL.Size = new System.Drawing.Size(240, 163);
            this.btnPIL.TabIndex = 2;
            this.btnPIL.Text = "PIL";
            this.btnPIL.UseVisualStyleBackColor = false;
            this.btnPIL.Click += new System.EventHandler(this.btnPIL_Click);
            // 
            // btnScannen
            // 
            this.btnScannen.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnScannen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScannen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScannen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnScannen.Location = new System.Drawing.Point(495, 203);
            this.btnScannen.Name = "btnScannen";
            this.btnScannen.Size = new System.Drawing.Size(240, 163);
            this.btnScannen.TabIndex = 3;
            this.btnScannen.Text = "Scannen";
            this.btnScannen.UseVisualStyleBackColor = false;
            this.btnScannen.Click += new System.EventHandler(this.btnScannen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(739, 370);
            this.Controls.Add(this.btnScannen);
            this.Controls.Add(this.btnPIL);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(300, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnPIL;
        private System.Windows.Forms.Button btnScannen;
    }
}

