﻿namespace Wypozyczalnia
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
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(12, 502);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(164, 20);
            this.txtImie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(12, 557);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(164, 20);
            this.txtNazwisko.TabIndex = 2;
            // 
            // txtPesel
            // 
            this.txtPesel.AutoSize = true;
            this.txtPesel.Location = new System.Drawing.Point(12, 597);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(33, 13);
            this.txtPesel.TabIndex = 5;
            this.txtPesel.Text = "Pesel";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 616);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 659);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nr kontaktowy";
            // 
            // txtNrKontaktowy
            // 
            this.txtNrKontaktowy.Location = new System.Drawing.Point(12, 678);
            this.txtNrKontaktowy.Name = "txtNrKontaktowy";
            this.txtNrKontaktowy.Size = new System.Drawing.Size(164, 20);
            this.txtNrKontaktowy.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 332);
            this.dataGridView1.TabIndex = 8;
            // 
            // dropKategorie
            // 
            this.dropKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropKategorie.FormattingEnabled = true;
            this.dropKategorie.Items.AddRange(new object[] {
            "szit",
            "szrot"});
            this.dropKategorie.Location = new System.Drawing.Point(12, 45);
            this.dropKategorie.Name = "dropKategorie";
            this.dropKategorie.Size = new System.Drawing.Size(176, 21);
            this.dropKategorie.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wybierz kategorię sprzętu";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(603, 110);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(479, 332);
            this.dataGridView2.TabIndex = 11;
            // 
            // btnDodajDoZamowienia
            // 
            this.btnDodajDoZamowienia.Location = new System.Drawing.Point(510, 244);
            this.btnDodajDoZamowienia.Name = "btnDodajDoZamowienia";
            this.btnDodajDoZamowienia.Size = new System.Drawing.Size(75, 23);
            this.btnDodajDoZamowienia.TabIndex = 12;
            this.btnDodajDoZamowienia.Text = ">>>";
            this.btnDodajDoZamowienia.UseVisualStyleBackColor = true;
            // 
            // btnUsunZzamowienia
            // 
            this.btnUsunZzamowienia.Location = new System.Drawing.Point(510, 291);
            this.btnUsunZzamowienia.Name = "btnUsunZzamowienia";
            this.btnUsunZzamowienia.Size = new System.Drawing.Size(75, 23);
            this.btnUsunZzamowienia.TabIndex = 13;
            this.btnUsunZzamowienia.Text = "<<<";
            this.btnUsunZzamowienia.UseVisualStyleBackColor = true;
            // 
            // dropCzasWypozyczenia
            // 
            this.dropCzasWypozyczenia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropCzasWypozyczenia.FormattingEnabled = true;
            this.dropCzasWypozyczenia.Location = new System.Drawing.Point(293, 502);
            this.dropCzasWypozyczenia.Name = "dropCzasWypozyczenia";
            this.dropCzasWypozyczenia.Size = new System.Drawing.Size(149, 21);
            this.dropCzasWypozyczenia.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Czas wypożyczenia w dobach";
            // 
            // btnWypozycz
            // 
            this.btnWypozycz.BackColor = System.Drawing.Color.Lime;
            this.btnWypozycz.Location = new System.Drawing.Point(293, 557);
            this.btnWypozycz.Name = "btnWypozycz";
            this.btnWypozycz.Size = new System.Drawing.Size(149, 61);
            this.btnWypozycz.TabIndex = 16;
            this.btnWypozycz.Text = "Zatwierdź";
            this.btnWypozycz.UseVisualStyleBackColor = false;
            // 
            // formEkranKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 811);
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
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImie);
            this.Name = "formEkranKlienta";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNrKontaktowy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox dropKategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDodajDoZamowienia;
        private System.Windows.Forms.Button btnUsunZzamowienia;
        private System.Windows.Forms.ComboBox dropCzasWypozyczenia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWypozycz;
    }
}

