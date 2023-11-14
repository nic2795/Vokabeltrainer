namespace Vokabeltrainer
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
            this.txtVokabelVorgabe = new System.Windows.Forms.TextBox();
            this.txtVokabelAntwort = new System.Windows.Forms.TextBox();
            this.cboSelectLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.btnWeiter = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVokabelVorgabe
            // 
            this.txtVokabelVorgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVokabelVorgabe.Location = new System.Drawing.Point(16, 132);
            this.txtVokabelVorgabe.Name = "txtVokabelVorgabe";
            this.txtVokabelVorgabe.ReadOnly = true;
            this.txtVokabelVorgabe.Size = new System.Drawing.Size(188, 29);
            this.txtVokabelVorgabe.TabIndex = 0;
            // 
            // txtVokabelAntwort
            // 
            this.txtVokabelAntwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVokabelAntwort.Location = new System.Drawing.Point(270, 132);
            this.txtVokabelAntwort.Name = "txtVokabelAntwort";
            this.txtVokabelAntwort.Size = new System.Drawing.Size(193, 29);
            this.txtVokabelAntwort.TabIndex = 1;
            // 
            // cboSelectLanguage
            // 
            this.cboSelectLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectLanguage.FormattingEnabled = true;
            this.cboSelectLanguage.Items.AddRange(new object[] {
            "DE-EN",
            "EN-DE",
            "DE-SP",
            "SP-DE",
            "DE-FR",
            "FR-DE"});
            this.cboSelectLanguage.Location = new System.Drawing.Point(205, 36);
            this.cboSelectLanguage.Name = "cboSelectLanguage";
            this.cboSelectLanguage.Size = new System.Drawing.Size(258, 32);
            this.cboSelectLanguage.TabIndex = 2;
            this.cboSelectLanguage.SelectedIndexChanged += new System.EventHandler(this.WahlCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bitte Sprache wählen:";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.StartButton.Location = new System.Drawing.Point(484, 33);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(139, 36);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // btnWeiter
            // 
            this.btnWeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeiter.Location = new System.Drawing.Point(484, 132);
            this.btnWeiter.Name = "btnWeiter";
            this.btnWeiter.Size = new System.Drawing.Size(139, 29);
            this.btnWeiter.TabIndex = 5;
            this.btnWeiter.Text = "Weiter";
            this.btnWeiter.UseVisualStyleBackColor = true;
            this.btnWeiter.Click += new System.EventHandler(this.btnWeiter_Click);
            // 
            // cmdBeenden
            // 
            this.cmdBeenden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.cmdBeenden.Location = new System.Drawing.Point(16, 239);
            this.cmdBeenden.Name = "cmdBeenden";
            this.cmdBeenden.Size = new System.Drawing.Size(607, 30);
            this.cmdBeenden.TabIndex = 6;
            this.cmdBeenden.Text = "Beenden";
            this.cmdBeenden.UseVisualStyleBackColor = true;
            this.cmdBeenden.Click += new System.EventHandler(this.cmdBeenden_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(744, 691);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 8;
            this.label2.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.Location = new System.Drawing.Point(187, 186);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(100, 13);
            this.lblErgebnis.TabIndex = 10;
            this.lblErgebnis.Text = "ErgebnisHinweis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 298);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.btnWeiter);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSelectLanguage);
            this.Controls.Add(this.txtVokabelAntwort);
            this.Controls.Add(this.txtVokabelVorgabe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Vokabeltrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVokabelVorgabe;
        private System.Windows.Forms.TextBox txtVokabelAntwort;
        private System.Windows.Forms.ComboBox cboSelectLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button btnWeiter;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblErgebnis;
    }
}

