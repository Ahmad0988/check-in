namespace projekt
{
    partial class Form4
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
            this.btnScannen = new System.Windows.Forms.Button();
            this.labelGepaeck = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lviScann = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.formZu = new System.Windows.Forms.Button();
            this.zuruecksetzen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scannen Gepäckstücke";
            // 
            // btnScannen
            // 
            this.btnScannen.BackColor = System.Drawing.Color.Navy;
            this.btnScannen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScannen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScannen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnScannen.Location = new System.Drawing.Point(291, 95);
            this.btnScannen.Name = "btnScannen";
            this.btnScannen.Size = new System.Drawing.Size(189, 60);
            this.btnScannen.TabIndex = 6;
            this.btnScannen.Text = "Scannen";
            this.btnScannen.UseVisualStyleBackColor = false;
            this.btnScannen.Click += new System.EventHandler(this.btnScannen_Click);
            // 
            // labelGepaeck
            // 
            this.labelGepaeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGepaeck.Location = new System.Drawing.Point(423, 54);
            this.labelGepaeck.Name = "labelGepaeck";
            this.labelGepaeck.Size = new System.Drawing.Size(296, 23);
            this.labelGepaeck.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitte das Label des Gepäcks eingeben: ";
            // 
            // lviScann
            // 
            this.lviScann.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lviScann.FullRowSelect = true;
            this.lviScann.GridLines = true;
            this.lviScann.HideSelection = false;
            this.lviScann.Location = new System.Drawing.Point(6, 161);
            this.lviScann.Name = "lviScann";
            this.lviScann.Size = new System.Drawing.Size(782, 81);
            this.lviScann.TabIndex = 7;
            this.lviScann.UseCompatibleStateImageBehavior = false;
            this.lviScann.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Flugnummer";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nachname";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vorname";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Passnummer";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "von";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "bis";
            this.columnHeader6.Width = 130;
            // 
            // formZu
            // 
            this.formZu.BackColor = System.Drawing.Color.Navy;
            this.formZu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formZu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formZu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.formZu.Location = new System.Drawing.Point(6, 260);
            this.formZu.Name = "formZu";
            this.formZu.Size = new System.Drawing.Size(350, 47);
            this.formZu.TabIndex = 44;
            this.formZu.Text = "Zurück zur Startseite";
            this.formZu.UseVisualStyleBackColor = false;
            this.formZu.Click += new System.EventHandler(this.formZu_Click);
            // 
            // zuruecksetzen
            // 
            this.zuruecksetzen.BackColor = System.Drawing.Color.Navy;
            this.zuruecksetzen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zuruecksetzen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zuruecksetzen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zuruecksetzen.Location = new System.Drawing.Point(438, 260);
            this.zuruecksetzen.Name = "zuruecksetzen";
            this.zuruecksetzen.Size = new System.Drawing.Size(350, 47);
            this.zuruecksetzen.TabIndex = 45;
            this.zuruecksetzen.Text = "Neu Scannen";
            this.zuruecksetzen.UseVisualStyleBackColor = false;
            this.zuruecksetzen.Click += new System.EventHandler(this.zuruecksetzen_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.zuruecksetzen);
            this.Controls.Add(this.formZu);
            this.Controls.Add(this.lviScann);
            this.Controls.Add(this.btnScannen);
            this.Controls.Add(this.labelGepaeck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(300, 100);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Scann";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScannen;
        private System.Windows.Forms.TextBox labelGepaeck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lviScann;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button formZu;
        private System.Windows.Forms.Button zuruecksetzen;
    }
}