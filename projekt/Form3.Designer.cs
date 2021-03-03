namespace projekt
{
    partial class Form3
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
            this.lviFluege = new System.Windows.Forms.ListView();
            this.Flugnummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Startort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zielort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abflugzeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lviPIL = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.freiPlaetze_ = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.formZu = new System.Windows.Forms.Button();
            this.anZahlPassagiere = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fluglist";
            // 
            // lviFluege
            // 
            this.lviFluege.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Flugnummer,
            this.Startort,
            this.Zielort,
            this.Abflugzeit});
            this.lviFluege.FullRowSelect = true;
            this.lviFluege.GridLines = true;
            this.lviFluege.HideSelection = false;
            this.lviFluege.Location = new System.Drawing.Point(12, 33);
            this.lviFluege.Name = "lviFluege";
            this.lviFluege.Size = new System.Drawing.Size(782, 105);
            this.lviFluege.TabIndex = 2;
            this.lviFluege.UseCompatibleStateImageBehavior = false;
            this.lviFluege.View = System.Windows.Forms.View.Details;
            this.lviFluege.SelectedIndexChanged += new System.EventHandler(this.lviFluege_SelectedIndexChanged);
            // 
            // Flugnummer
            // 
            this.Flugnummer.Text = "Flugnummer";
            this.Flugnummer.Width = 194;
            // 
            // Startort
            // 
            this.Startort.Text = "Startort";
            this.Startort.Width = 194;
            // 
            // Zielort
            // 
            this.Zielort.Text = "Zielort";
            this.Zielort.Width = 194;
            // 
            // Abflugzeit
            // 
            this.Abflugzeit.Text = "Abflugzeit";
            this.Abflugzeit.Width = 196;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(782, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passenger Information List";
            // 
            // lviPIL
            // 
            this.lviPIL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lviPIL.FullRowSelect = true;
            this.lviPIL.GridLines = true;
            this.lviPIL.HideSelection = false;
            this.lviPIL.Location = new System.Drawing.Point(12, 164);
            this.lviPIL.Name = "lviPIL";
            this.lviPIL.Size = new System.Drawing.Size(782, 258);
            this.lviPIL.TabIndex = 4;
            this.lviPIL.UseCompatibleStateImageBehavior = false;
            this.lviPIL.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ticketnummer";
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
            this.columnHeader4.Text = "TYP_Ticket";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sitzplatznummer";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Passnummer";
            this.columnHeader6.Width = 130;
            // 
            // freiPlaetze_
            // 
            this.freiPlaetze_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freiPlaetze_.Location = new System.Drawing.Point(582, 442);
            this.freiPlaetze_.Name = "freiPlaetze_";
            this.freiPlaetze_.ReadOnly = true;
            this.freiPlaetze_.Size = new System.Drawing.Size(106, 23);
            this.freiPlaetze_.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(694, 445);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 17);
            this.label18.TabIndex = 40;
            this.label18.Text = "Frei Plätze";
            // 
            // formZu
            // 
            this.formZu.BackColor = System.Drawing.Color.Navy;
            this.formZu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formZu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formZu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.formZu.Location = new System.Drawing.Point(12, 428);
            this.formZu.Name = "formZu";
            this.formZu.Size = new System.Drawing.Size(216, 47);
            this.formZu.TabIndex = 43;
            this.formZu.Text = "Zurück zur Startseite";
            this.formZu.UseVisualStyleBackColor = false;
            this.formZu.Click += new System.EventHandler(this.formZu_Click);
            // 
            // anZahlPassagiere
            // 
            this.anZahlPassagiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anZahlPassagiere.Location = new System.Drawing.Point(248, 440);
            this.anZahlPassagiere.Name = "anZahlPassagiere";
            this.anZahlPassagiere.ReadOnly = true;
            this.anZahlPassagiere.Size = new System.Drawing.Size(106, 23);
            this.anZahlPassagiere.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(360, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Passagiere mit Standby Ticket";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.anZahlPassagiere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formZu);
            this.Controls.Add(this.freiPlaetze_);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lviPIL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lviFluege);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(300, 100);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PIL";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lviFluege;
        private System.Windows.Forms.ColumnHeader Flugnummer;
        private System.Windows.Forms.ColumnHeader Startort;
        private System.Windows.Forms.ColumnHeader Zielort;
        private System.Windows.Forms.ColumnHeader Abflugzeit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lviPIL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox freiPlaetze_;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button formZu;
        private System.Windows.Forms.TextBox anZahlPassagiere;
        private System.Windows.Forms.Label label3;
    }
}