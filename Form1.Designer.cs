namespace Wypozyczalnia
{
    partial class formEkranKlienta
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEkranKlienta));
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.Label();
            this.txtPeselK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNrKontaktowy = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dropKategorie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDodajDoZamowienia = new System.Windows.Forms.Button();
            this.btnUsunZzamowienia = new System.Windows.Forms.Button();
            this.dropCzasWypozyczenia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWypozycz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LblSumaZamowienia = new System.Windows.Forms.Label();
            this.lblCenaZamowienia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(15, 429);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(176, 20);
            this.txtImie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(15, 480);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(176, 20);
            this.txtNazwisko.TabIndex = 2;
            // 
            // txtPesel
            // 
            this.txtPesel.AutoSize = true;
            this.txtPesel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPesel.Location = new System.Drawing.Point(15, 503);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(38, 15);
            this.txtPesel.TabIndex = 5;
            this.txtPesel.Text = "Pesel";
            // 
            // txtPeselK
            // 
            this.txtPeselK.Location = new System.Drawing.Point(15, 524);
            this.txtPeselK.Name = "txtPeselK";
            this.txtPeselK.Size = new System.Drawing.Size(176, 20);
            this.txtPeselK.TabIndex = 4;
            this.txtPeselK.TextChanged += new System.EventHandler(this.txtPeselK_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nr kontaktowy";
            // 
            // txtNrKontaktowy
            // 
            this.txtNrKontaktowy.Location = new System.Drawing.Point(15, 567);
            this.txtNrKontaktowy.Name = "txtNrKontaktowy";
            this.txtNrKontaktowy.Size = new System.Drawing.Size(179, 20);
            this.txtNrKontaktowy.TabIndex = 6;
            this.txtNrKontaktowy.TextChanged += new System.EventHandler(this.txtNrKontaktowy_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 67);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(479, 332);
            this.dataGridView1.TabIndex = 8;
            // 
            // dropKategorie
            // 
            this.dropKategorie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dropKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropKategorie.FormattingEnabled = true;
            this.dropKategorie.Location = new System.Drawing.Point(15, 31);
            this.dropKategorie.Name = "dropKategorie";
            this.dropKategorie.Size = new System.Drawing.Size(176, 21);
            this.dropKategorie.TabIndex = 9;
            this.dropKategorie.SelectedIndexChanged += new System.EventHandler(this.dropKategorie_SelectedIndexChanged);
            this.dropKategorie.SelectedValueChanged += new System.EventHandler(this.dropKategorie_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wybierz kategorię sprzętu";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(603, 67);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(506, 332);
            this.dataGridView2.TabIndex = 11;
            // 
            // btnDodajDoZamowienia
            // 
            this.btnDodajDoZamowienia.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDodajDoZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajDoZamowienia.Location = new System.Drawing.Point(510, 201);
            this.btnDodajDoZamowienia.Name = "btnDodajDoZamowienia";
            this.btnDodajDoZamowienia.Size = new System.Drawing.Size(75, 23);
            this.btnDodajDoZamowienia.TabIndex = 12;
            this.btnDodajDoZamowienia.Text = ">>>";
            this.btnDodajDoZamowienia.UseVisualStyleBackColor = false;
            this.btnDodajDoZamowienia.Click += new System.EventHandler(this.btnDodajDoZamowienia_Click);
            // 
            // btnUsunZzamowienia
            // 
            this.btnUsunZzamowienia.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsunZzamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunZzamowienia.Location = new System.Drawing.Point(510, 248);
            this.btnUsunZzamowienia.Name = "btnUsunZzamowienia";
            this.btnUsunZzamowienia.Size = new System.Drawing.Size(75, 23);
            this.btnUsunZzamowienia.TabIndex = 13;
            this.btnUsunZzamowienia.Text = "<<<";
            this.btnUsunZzamowienia.UseVisualStyleBackColor = false;
            this.btnUsunZzamowienia.Click += new System.EventHandler(this.btnUsunZzamowienia_Click);
            // 
            // dropCzasWypozyczenia
            // 
            this.dropCzasWypozyczenia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropCzasWypozyczenia.FormattingEnabled = true;
            this.dropCzasWypozyczenia.Location = new System.Drawing.Point(263, 428);
            this.dropCzasWypozyczenia.Name = "dropCzasWypozyczenia";
            this.dropCzasWypozyczenia.Size = new System.Drawing.Size(179, 21);
            this.dropCzasWypozyczenia.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(265, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Czas wypożyczenia w dobach";
            // 
            // btnWypozycz
            // 
            this.btnWypozycz.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnWypozycz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWypozycz.Location = new System.Drawing.Point(263, 551);
            this.btnWypozycz.Name = "btnWypozycz";
            this.btnWypozycz.Size = new System.Drawing.Size(179, 39);
            this.btnWypozycz.TabIndex = 16;
            this.btnWypozycz.Text = "Zatwierdź";
            this.btnWypozycz.UseVisualStyleBackColor = false;
            this.btnWypozycz.Click += new System.EventHandler(this.btnWypozycz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(609, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cena za dobę w  PLN:";
            // 
            // LblSumaZamowienia
            // 
            this.LblSumaZamowienia.AutoSize = true;
            this.LblSumaZamowienia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblSumaZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblSumaZamowienia.Location = new System.Drawing.Point(776, 410);
            this.LblSumaZamowienia.Name = "LblSumaZamowienia";
            this.LblSumaZamowienia.Size = new System.Drawing.Size(14, 16);
            this.LblSumaZamowienia.TabIndex = 18;
            this.LblSumaZamowienia.Text = "0";
            // 
            // lblCenaZamowienia
            // 
            this.lblCenaZamowienia.AutoSize = true;
            this.lblCenaZamowienia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCenaZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCenaZamowienia.Location = new System.Drawing.Point(776, 433);
            this.lblCenaZamowienia.Name = "lblCenaZamowienia";
            this.lblCenaZamowienia.Size = new System.Drawing.Size(14, 16);
            this.lblCenaZamowienia.TabIndex = 19;
            this.lblCenaZamowienia.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(609, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Suma zamówienia w  PLN:";
            // 
            // formEkranKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1140, 628);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCenaZamowienia);
            this.Controls.Add(this.LblSumaZamowienia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnWypozycz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dropCzasWypozyczenia);
            this.Controls.Add(this.btnUsunZzamowienia);
            this.Controls.Add(this.btnDodajDoZamowienia);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dropKategorie);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNrKontaktowy);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.txtPeselK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formEkranKlienta";
            this.Text = "Panel wypożyczania";
            this.Load += new System.EventHandler(this.formEkranKlienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label txtPesel;
        private System.Windows.Forms.TextBox txtPeselK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNrKontaktowy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox dropKategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodajDoZamowienia;
        private System.Windows.Forms.Button btnUsunZzamowienia;
        private System.Windows.Forms.ComboBox dropCzasWypozyczenia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWypozycz;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblSumaZamowienia;
        private System.Windows.Forms.Label lblCenaZamowienia;
        private System.Windows.Forms.Label label7;
    }
}

