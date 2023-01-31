namespace Wypozyczalnia
{
    partial class formPracownik
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRozmiarDodaj = new System.Windows.Forms.TextBox();
            this.txtNazwaDodaj = new System.Windows.Forms.TextBox();
            this.btnUsunSprzetZmagazynu = new System.Windows.Forms.Button();
            this.btnDodajSprzetDoMagazynu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTypDodaj = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTypP = new System.Windows.Forms.ComboBox();
            this.dgvMagazynP = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnUsunZamowienie = new System.Windows.Forms.Button();
            this.btnAktualizuj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSzukajZamowienia = new System.Windows.Forms.Button();
            this.txtWyszukajAktywne = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnWypozycz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dropCzasWypozyczenia = new System.Windows.Forms.ComboBox();
            this.btnUsunZzamowienia = new System.Windows.Forms.Button();
            this.btnDodajDoZamowienia = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dropKategorie = new System.Windows.Forms.ComboBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNrKontaktowy = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.numRegalDodaj = new System.Windows.Forms.NumericUpDown();
            this.numPolkaDodaj = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynP)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegalDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolkaDodaj)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1099, 735);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numPolkaDodaj);
            this.tabPage1.Controls.Add(this.numRegalDodaj);
            this.tabPage1.Controls.Add(this.txtRozmiarDodaj);
            this.tabPage1.Controls.Add(this.txtNazwaDodaj);
            this.tabPage1.Controls.Add(this.btnUsunSprzetZmagazynu);
            this.tabPage1.Controls.Add(this.btnDodajSprzetDoMagazynu);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboTypDodaj);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboTypP);
            this.tabPage1.Controls.Add(this.dgvMagazynP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1091, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Magazyn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRozmiarDodaj
            // 
            this.txtRozmiarDodaj.Location = new System.Drawing.Point(12, 512);
            this.txtRozmiarDodaj.Name = "txtRozmiarDodaj";
            this.txtRozmiarDodaj.Size = new System.Drawing.Size(100, 20);
            this.txtRozmiarDodaj.TabIndex = 18;
            // 
            // txtNazwaDodaj
            // 
            this.txtNazwaDodaj.Location = new System.Drawing.Point(12, 486);
            this.txtNazwaDodaj.Name = "txtNazwaDodaj";
            this.txtNazwaDodaj.Size = new System.Drawing.Size(100, 20);
            this.txtNazwaDodaj.TabIndex = 17;
            // 
            // btnUsunSprzetZmagazynu
            // 
            this.btnUsunSprzetZmagazynu.Location = new System.Drawing.Point(780, 68);
            this.btnUsunSprzetZmagazynu.Name = "btnUsunSprzetZmagazynu";
            this.btnUsunSprzetZmagazynu.Size = new System.Drawing.Size(148, 23);
            this.btnUsunSprzetZmagazynu.TabIndex = 16;
            this.btnUsunSprzetZmagazynu.Text = "Usuń zaznaczony sprzęt";
            this.btnUsunSprzetZmagazynu.UseVisualStyleBackColor = true;
            // 
            // btnDodajSprzetDoMagazynu
            // 
            this.btnDodajSprzetDoMagazynu.Location = new System.Drawing.Point(444, 616);
            this.btnDodajSprzetDoMagazynu.Name = "btnDodajSprzetDoMagazynu";
            this.btnDodajSprzetDoMagazynu.Size = new System.Drawing.Size(148, 23);
            this.btnDodajSprzetDoMagazynu.TabIndex = 15;
            this.btnDodajSprzetDoMagazynu.Text = "Dodaj sprzęt do magazynu";
            this.btnDodajSprzetDoMagazynu.UseVisualStyleBackColor = true;
            this.btnDodajSprzetDoMagazynu.Click += new System.EventHandler(this.btnDodajSprzetDoMagazynu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kategoria";
            // 
            // comboTypDodaj
            // 
            this.comboTypDodaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypDodaj.FormattingEnabled = true;
            this.comboTypDodaj.Location = new System.Drawing.Point(12, 459);
            this.comboTypDodaj.Name = "comboTypDodaj";
            this.comboTypDodaj.Size = new System.Drawing.Size(121, 21);
            this.comboTypDodaj.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dodawanie nowego sprzętu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wybierz kategorię sprzętu";
            // 
            // comboTypP
            // 
            this.comboTypP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypP.FormattingEnabled = true;
            this.comboTypP.Location = new System.Drawing.Point(9, 32);
            this.comboTypP.Name = "comboTypP";
            this.comboTypP.Size = new System.Drawing.Size(121, 21);
            this.comboTypP.TabIndex = 1;
            this.comboTypP.SelectedIndexChanged += new System.EventHandler(this.comboTypP_SelectedIndexChanged);
            // 
            // dgvMagazynP
            // 
            this.dgvMagazynP.AllowUserToAddRows = false;
            this.dgvMagazynP.AllowUserToDeleteRows = false;
            this.dgvMagazynP.AllowUserToResizeColumns = false;
            this.dgvMagazynP.AllowUserToResizeRows = false;
            this.dgvMagazynP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMagazynP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazynP.Location = new System.Drawing.Point(9, 68);
            this.dgvMagazynP.MultiSelect = false;
            this.dgvMagazynP.Name = "dgvMagazynP";
            this.dgvMagazynP.ReadOnly = true;
            this.dgvMagazynP.Size = new System.Drawing.Size(731, 332);
            this.dgvMagazynP.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.btnUsunZamowienie);
            this.tabPage2.Controls.Add(this.btnAktualizuj);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnSzukajZamowienia);
            this.tabPage2.Controls.Add(this.txtWyszukajAktywne);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1091, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aktywne Zamówienia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(38, 335);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(704, 211);
            this.dataGridView3.TabIndex = 6;
            // 
            // btnUsunZamowienie
            // 
            this.btnUsunZamowienie.Location = new System.Drawing.Point(204, 572);
            this.btnUsunZamowienie.Name = "btnUsunZamowienie";
            this.btnUsunZamowienie.Size = new System.Drawing.Size(144, 23);
            this.btnUsunZamowienie.TabIndex = 5;
            this.btnUsunZamowienie.Text = "Usuń zamówienie";
            this.btnUsunZamowienie.UseVisualStyleBackColor = true;
            // 
            // btnAktualizuj
            // 
            this.btnAktualizuj.Location = new System.Drawing.Point(38, 572);
            this.btnAktualizuj.Name = "btnAktualizuj";
            this.btnAktualizuj.Size = new System.Drawing.Size(144, 23);
            this.btnAktualizuj.TabIndex = 4;
            this.btnAktualizuj.Text = "Aktualizuj zamówienie";
            this.btnAktualizuj.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(790, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wyszukiwanie zamówienia po numerze";
            // 
            // btnSzukajZamowienia
            // 
            this.btnSzukajZamowienia.Location = new System.Drawing.Point(793, 118);
            this.btnSzukajZamowienia.Name = "btnSzukajZamowienia";
            this.btnSzukajZamowienia.Size = new System.Drawing.Size(100, 28);
            this.btnSzukajZamowienia.TabIndex = 2;
            this.btnSzukajZamowienia.Text = "Szukaj";
            this.btnSzukajZamowienia.UseVisualStyleBackColor = true;
            // 
            // txtWyszukajAktywne
            // 
            this.txtWyszukajAktywne.Location = new System.Drawing.Point(793, 72);
            this.txtWyszukajAktywne.Name = "txtWyszukajAktywne";
            this.txtWyszukajAktywne.Size = new System.Drawing.Size(188, 20);
            this.txtWyszukajAktywne.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(38, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(704, 222);
            this.dataGridView2.TabIndex = 0;
            // 
            // col1
            // 
            this.col1.HeaderText = "Column1";
            this.col1.Name = "col1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnWypozycz);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dropCzasWypozyczenia);
            this.tabPage3.Controls.Add(this.btnUsunZzamowienia);
            this.tabPage3.Controls.Add(this.btnDodajDoZamowienia);
            this.tabPage3.Controls.Add(this.dataGridView4);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.dropKategorie);
            this.tabPage3.Controls.Add(this.dataGridView5);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtNrKontaktowy);
            this.tabPage3.Controls.Add(this.txtPesel);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtNazwisko);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtImie);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1091, 709);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tworzenie zamówienia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnWypozycz
            // 
            this.btnWypozycz.BackColor = System.Drawing.Color.Lime;
            this.btnWypozycz.Location = new System.Drawing.Point(290, 531);
            this.btnWypozycz.Name = "btnWypozycz";
            this.btnWypozycz.Size = new System.Drawing.Size(149, 61);
            this.btnWypozycz.TabIndex = 33;
            this.btnWypozycz.Text = "Zatwierdź";
            this.btnWypozycz.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Czas wypożyczenia w dobach";
            // 
            // dropCzasWypozyczenia
            // 
            this.dropCzasWypozyczenia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropCzasWypozyczenia.FormattingEnabled = true;
            this.dropCzasWypozyczenia.Location = new System.Drawing.Point(290, 476);
            this.dropCzasWypozyczenia.Name = "dropCzasWypozyczenia";
            this.dropCzasWypozyczenia.Size = new System.Drawing.Size(149, 21);
            this.dropCzasWypozyczenia.TabIndex = 31;
            // 
            // btnUsunZzamowienia
            // 
            this.btnUsunZzamowienia.Location = new System.Drawing.Point(507, 265);
            this.btnUsunZzamowienia.Name = "btnUsunZzamowienia";
            this.btnUsunZzamowienia.Size = new System.Drawing.Size(75, 23);
            this.btnUsunZzamowienia.TabIndex = 30;
            this.btnUsunZzamowienia.Text = "<<<";
            this.btnUsunZzamowienia.UseVisualStyleBackColor = true;
            // 
            // btnDodajDoZamowienia
            // 
            this.btnDodajDoZamowienia.Location = new System.Drawing.Point(507, 218);
            this.btnDodajDoZamowienia.Name = "btnDodajDoZamowienia";
            this.btnDodajDoZamowienia.Size = new System.Drawing.Size(75, 23);
            this.btnDodajDoZamowienia.TabIndex = 29;
            this.btnDodajDoZamowienia.Text = ">>>";
            this.btnDodajDoZamowienia.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(600, 84);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(479, 332);
            this.dataGridView4.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Wybierz kategorię sprzętu";
            // 
            // dropKategorie
            // 
            this.dropKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropKategorie.FormattingEnabled = true;
            this.dropKategorie.Items.AddRange(new object[] {
            "szit",
            "szrot"});
            this.dropKategorie.Location = new System.Drawing.Point(12, 35);
            this.dropKategorie.Name = "dropKategorie";
            this.dropKategorie.Size = new System.Drawing.Size(176, 21);
            this.dropKategorie.TabIndex = 26;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(12, 84);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(479, 332);
            this.dataGridView5.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 609);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nr kontaktowy";
            // 
            // txtNrKontaktowy
            // 
            this.txtNrKontaktowy.Location = new System.Drawing.Point(17, 634);
            this.txtNrKontaktowy.Name = "txtNrKontaktowy";
            this.txtNrKontaktowy.Size = new System.Drawing.Size(164, 20);
            this.txtNrKontaktowy.TabIndex = 23;
            // 
            // txtPesel
            // 
            this.txtPesel.AutoSize = true;
            this.txtPesel.Location = new System.Drawing.Point(14, 555);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(33, 13);
            this.txtPesel.TabIndex = 22;
            this.txtPesel.Text = "Pesel";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 572);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 20);
            this.textBox3.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(17, 518);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(164, 20);
            this.txtNazwisko.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Imię";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(17, 466);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(164, 20);
            this.txtImie.TabIndex = 17;
            // 
            // numRegalDodaj
            // 
            this.numRegalDodaj.Location = new System.Drawing.Point(12, 538);
            this.numRegalDodaj.Name = "numRegalDodaj";
            this.numRegalDodaj.Size = new System.Drawing.Size(120, 20);
            this.numRegalDodaj.TabIndex = 19;
            // 
            // numPolkaDodaj
            // 
            this.numPolkaDodaj.Location = new System.Drawing.Point(13, 564);
            this.numPolkaDodaj.Name = "numPolkaDodaj";
            this.numPolkaDodaj.Size = new System.Drawing.Size(120, 20);
            this.numPolkaDodaj.TabIndex = 20;
            // 
            // formPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 747);
            this.Controls.Add(this.tabControl1);
            this.Name = "formPracownik";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.formPracownik_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynP)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegalDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolkaDodaj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboTypP;
        private System.Windows.Forms.DataGridView dgvMagazynP;
        private System.Windows.Forms.Button btnUsunSprzetZmagazynu;
        private System.Windows.Forms.Button btnDodajSprzetDoMagazynu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTypDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSzukajZamowienia;
        private System.Windows.Forms.TextBox txtWyszukajAktywne;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnUsunZamowienie;
        private System.Windows.Forms.Button btnAktualizuj;
        private System.Windows.Forms.Button btnWypozycz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dropCzasWypozyczenia;
        private System.Windows.Forms.Button btnUsunZzamowienia;
        private System.Windows.Forms.Button btnDodajDoZamowienia;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dropKategorie;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNrKontaktowy;
        private System.Windows.Forms.Label txtPesel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtRozmiarDodaj;
        private System.Windows.Forms.TextBox txtNazwaDodaj;
        private System.Windows.Forms.NumericUpDown numPolkaDodaj;
        private System.Windows.Forms.NumericUpDown numRegalDodaj;
    }
}