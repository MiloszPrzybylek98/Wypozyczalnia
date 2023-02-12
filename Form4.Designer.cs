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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnWydaj = new System.Windows.Forms.Button();
            this.btnCzyscSzukanie = new System.Windows.Forms.Button();
            this.dgvWorekZamP = new System.Windows.Forms.DataGridView();
            this.btnUsunZamowienie = new System.Windows.Forms.Button();
            this.btnRozlicz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSzukajZamowienia = new System.Windows.Forms.Button();
            this.txtWyszukajAktywne = new System.Windows.Forms.TextBox();
            this.dgvAktywneZamP = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.numCena = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numPolkaDodaj = new System.Windows.Forms.NumericUpDown();
            this.numRegalDodaj = new System.Windows.Forms.NumericUpDown();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnNoweZamowienie = new System.Windows.Forms.Button();
            this.LblSumaZamowienia = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnWypozycz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dropCzasWypozyczenia = new System.Windows.Forms.ComboBox();
            this.btnUsunZzamowienia = new System.Windows.Forms.Button();
            this.btnDodajDoZamowienia = new System.Windows.Forms.Button();
            this.dgvWorek = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dropKategorie = new System.Windows.Forms.ComboBox();
            this.dgvWyborSprzetu = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNrKontaktowy = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorekZamP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktywneZamP)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolkaDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegalDodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynP)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyborSprzetu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1098, 737);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Wypozyczalnia.Properties.Resources.koryaksky_volcano_g3d56b61c0_1920;
            this.tabPage2.Controls.Add(this.btnWydaj);
            this.tabPage2.Controls.Add(this.btnCzyscSzukanie);
            this.tabPage2.Controls.Add(this.dgvWorekZamP);
            this.tabPage2.Controls.Add(this.btnUsunZamowienie);
            this.tabPage2.Controls.Add(this.btnRozlicz);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnSzukajZamowienia);
            this.tabPage2.Controls.Add(this.txtWyszukajAktywne);
            this.tabPage2.Controls.Add(this.dgvAktywneZamP);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1090, 711);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aktywne Zamówienia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnWydaj
            // 
            this.btnWydaj.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnWydaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWydaj.Location = new System.Drawing.Point(252, 572);
            this.btnWydaj.Name = "btnWydaj";
            this.btnWydaj.Size = new System.Drawing.Size(188, 36);
            this.btnWydaj.TabIndex = 8;
            this.btnWydaj.Text = "Wydaj zamówienie";
            this.btnWydaj.UseVisualStyleBackColor = false;
            this.btnWydaj.Click += new System.EventHandler(this.btnWydaj_Click);
            // 
            // btnCzyscSzukanie
            // 
            this.btnCzyscSzukanie.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCzyscSzukanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCzyscSzukanie.Location = new System.Drawing.Point(793, 174);
            this.btnCzyscSzukanie.Name = "btnCzyscSzukanie";
            this.btnCzyscSzukanie.Size = new System.Drawing.Size(188, 33);
            this.btnCzyscSzukanie.TabIndex = 7;
            this.btnCzyscSzukanie.Text = "Czyść szukanie";
            this.btnCzyscSzukanie.UseVisualStyleBackColor = false;
            this.btnCzyscSzukanie.Click += new System.EventHandler(this.btnCzyscSzukanie_Click);
            // 
            // dgvWorekZamP
            // 
            this.dgvWorekZamP.AllowUserToAddRows = false;
            this.dgvWorekZamP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorekZamP.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvWorekZamP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorekZamP.Location = new System.Drawing.Point(38, 335);
            this.dgvWorekZamP.MultiSelect = false;
            this.dgvWorekZamP.Name = "dgvWorekZamP";
            this.dgvWorekZamP.ReadOnly = true;
            this.dgvWorekZamP.RowHeadersVisible = false;
            this.dgvWorekZamP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorekZamP.Size = new System.Drawing.Size(704, 211);
            this.dgvWorekZamP.StandardTab = true;
            this.dgvWorekZamP.TabIndex = 6;
            // 
            // btnUsunZamowienie
            // 
            this.btnUsunZamowienie.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUsunZamowienie.Location = new System.Drawing.Point(793, 629);
            this.btnUsunZamowienie.Name = "btnUsunZamowienie";
            this.btnUsunZamowienie.Size = new System.Drawing.Size(188, 36);
            this.btnUsunZamowienie.TabIndex = 5;
            this.btnUsunZamowienie.Text = "Usuń zamówienie";
            this.btnUsunZamowienie.UseVisualStyleBackColor = false;
            this.btnUsunZamowienie.Click += new System.EventHandler(this.btnUsunZamowienie_Click);
            // 
            // btnRozlicz
            // 
            this.btnRozlicz.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRozlicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRozlicz.Location = new System.Drawing.Point(38, 572);
            this.btnRozlicz.Name = "btnRozlicz";
            this.btnRozlicz.Size = new System.Drawing.Size(188, 36);
            this.btnRozlicz.TabIndex = 4;
            this.btnRozlicz.Text = "Rozlicz zamówienie";
            this.btnRozlicz.UseVisualStyleBackColor = false;
            this.btnRozlicz.Click += new System.EventHandler(this.btnRozlicz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(790, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wyszukiwanie zamówienia po ID";
            // 
            // btnSzukajZamowienia
            // 
            this.btnSzukajZamowienia.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSzukajZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukajZamowienia.Location = new System.Drawing.Point(793, 118);
            this.btnSzukajZamowienia.Name = "btnSzukajZamowienia";
            this.btnSzukajZamowienia.Size = new System.Drawing.Size(188, 33);
            this.btnSzukajZamowienia.TabIndex = 2;
            this.btnSzukajZamowienia.Text = "Szukaj";
            this.btnSzukajZamowienia.UseVisualStyleBackColor = false;
            this.btnSzukajZamowienia.Click += new System.EventHandler(this.btnSzukajZamowienia_Click);
            // 
            // txtWyszukajAktywne
            // 
            this.txtWyszukajAktywne.Location = new System.Drawing.Point(793, 75);
            this.txtWyszukajAktywne.Name = "txtWyszukajAktywne";
            this.txtWyszukajAktywne.Size = new System.Drawing.Size(188, 20);
            this.txtWyszukajAktywne.TabIndex = 1;
            // 
            // dgvAktywneZamP
            // 
            this.dgvAktywneZamP.AllowUserToAddRows = false;
            this.dgvAktywneZamP.AllowUserToDeleteRows = false;
            this.dgvAktywneZamP.AllowUserToResizeColumns = false;
            this.dgvAktywneZamP.AllowUserToResizeRows = false;
            this.dgvAktywneZamP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAktywneZamP.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvAktywneZamP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktywneZamP.Location = new System.Drawing.Point(38, 56);
            this.dgvAktywneZamP.MultiSelect = false;
            this.dgvAktywneZamP.Name = "dgvAktywneZamP";
            this.dgvAktywneZamP.ReadOnly = true;
            this.dgvAktywneZamP.RowHeadersVisible = false;
            this.dgvAktywneZamP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAktywneZamP.Size = new System.Drawing.Size(704, 222);
            this.dgvAktywneZamP.TabIndex = 0;
            this.dgvAktywneZamP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAktywneZamP_CellClick);
            this.dgvAktywneZamP.SelectionChanged += new System.EventHandler(this.dgvAktywneZamP_SelectionChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::Wypozyczalnia.Properties.Resources.koryaksky_volcano_g3d56b61c0_1920;
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.numCena);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
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
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1090, 711);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Magazyn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(210, 425);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Cena";
            // 
            // numCena
            // 
            this.numCena.Location = new System.Drawing.Point(213, 443);
            this.numCena.Name = "numCena";
            this.numCena.Size = new System.Drawing.Size(136, 21);
            this.numCena.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(33, 621);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Półka";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(32, 572);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Regał";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(33, 521);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Rozmiar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(33, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Nazwa";
            // 
            // numPolkaDodaj
            // 
            this.numPolkaDodaj.Location = new System.Drawing.Point(31, 637);
            this.numPolkaDodaj.Name = "numPolkaDodaj";
            this.numPolkaDodaj.Size = new System.Drawing.Size(136, 21);
            this.numPolkaDodaj.TabIndex = 20;
            // 
            // numRegalDodaj
            // 
            this.numRegalDodaj.Location = new System.Drawing.Point(32, 588);
            this.numRegalDodaj.Name = "numRegalDodaj";
            this.numRegalDodaj.Size = new System.Drawing.Size(135, 21);
            this.numRegalDodaj.TabIndex = 19;
            // 
            // txtRozmiarDodaj
            // 
            this.txtRozmiarDodaj.Location = new System.Drawing.Point(31, 537);
            this.txtRozmiarDodaj.Name = "txtRozmiarDodaj";
            this.txtRozmiarDodaj.Size = new System.Drawing.Size(136, 21);
            this.txtRozmiarDodaj.TabIndex = 18;
            // 
            // txtNazwaDodaj
            // 
            this.txtNazwaDodaj.Location = new System.Drawing.Point(31, 487);
            this.txtNazwaDodaj.Name = "txtNazwaDodaj";
            this.txtNazwaDodaj.Size = new System.Drawing.Size(136, 21);
            this.txtNazwaDodaj.TabIndex = 17;
            // 
            // btnUsunSprzetZmagazynu
            // 
            this.btnUsunSprzetZmagazynu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUsunSprzetZmagazynu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunSprzetZmagazynu.Location = new System.Drawing.Point(790, 54);
            this.btnUsunSprzetZmagazynu.Name = "btnUsunSprzetZmagazynu";
            this.btnUsunSprzetZmagazynu.Size = new System.Drawing.Size(166, 31);
            this.btnUsunSprzetZmagazynu.TabIndex = 16;
            this.btnUsunSprzetZmagazynu.Text = "Usuń zaznaczony sprzęt";
            this.btnUsunSprzetZmagazynu.UseVisualStyleBackColor = false;
            this.btnUsunSprzetZmagazynu.Click += new System.EventHandler(this.btnUsunSprzetZmagazynu_Click);
            // 
            // btnDodajSprzetDoMagazynu
            // 
            this.btnDodajSprzetDoMagazynu.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajSprzetDoMagazynu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSprzetDoMagazynu.Location = new System.Drawing.Point(350, 637);
            this.btnDodajSprzetDoMagazynu.Name = "btnDodajSprzetDoMagazynu";
            this.btnDodajSprzetDoMagazynu.Size = new System.Drawing.Size(199, 42);
            this.btnDodajSprzetDoMagazynu.TabIndex = 15;
            this.btnDodajSprzetDoMagazynu.Text = "Dodaj sprzęt do magazynu";
            this.btnDodajSprzetDoMagazynu.UseVisualStyleBackColor = false;
            this.btnDodajSprzetDoMagazynu.Click += new System.EventHandler(this.btnDodajSprzetDoMagazynu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(33, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kategoria";
            // 
            // comboTypDodaj
            // 
            this.comboTypDodaj.BackColor = System.Drawing.Color.AliceBlue;
            this.comboTypDodaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypDodaj.FormattingEnabled = true;
            this.comboTypDodaj.Location = new System.Drawing.Point(31, 443);
            this.comboTypDodaj.Name = "comboTypDodaj";
            this.comboTypDodaj.Size = new System.Drawing.Size(136, 23);
            this.comboTypDodaj.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dodawanie nowego sprzętu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(33, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wybierz kategorię sprzętu";
            // 
            // comboTypP
            // 
            this.comboTypP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypP.FormattingEnabled = true;
            this.comboTypP.Location = new System.Drawing.Point(31, 31);
            this.comboTypP.Name = "comboTypP";
            this.comboTypP.Size = new System.Drawing.Size(136, 23);
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
            this.dgvMagazynP.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvMagazynP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazynP.Location = new System.Drawing.Point(31, 54);
            this.dgvMagazynP.MultiSelect = false;
            this.dgvMagazynP.Name = "dgvMagazynP";
            this.dgvMagazynP.ReadOnly = true;
            this.dgvMagazynP.RowHeadersVisible = false;
            this.dgvMagazynP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMagazynP.Size = new System.Drawing.Size(731, 332);
            this.dgvMagazynP.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Wypozyczalnia.Properties.Resources.koryaksky_volcano_g3d56b61c0_1920;
            this.tabPage3.Controls.Add(this.btnNoweZamowienie);
            this.tabPage3.Controls.Add(this.LblSumaZamowienia);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.btnWypozycz);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dropCzasWypozyczenia);
            this.tabPage3.Controls.Add(this.btnUsunZzamowienia);
            this.tabPage3.Controls.Add(this.btnDodajDoZamowienia);
            this.tabPage3.Controls.Add(this.dgvWorek);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.dropKategorie);
            this.tabPage3.Controls.Add(this.dgvWyborSprzetu);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtNrKontaktowy);
            this.tabPage3.Controls.Add(this.lblPesel);
            this.tabPage3.Controls.Add(this.txtPesel);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtNazwisko);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtImie);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1090, 711);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tworzenie zamówienia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnNoweZamowienie
            // 
            this.btnNoweZamowienie.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNoweZamowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNoweZamowienie.Location = new System.Drawing.Point(210, 13);
            this.btnNoweZamowienie.Name = "btnNoweZamowienie";
            this.btnNoweZamowienie.Size = new System.Drawing.Size(281, 61);
            this.btnNoweZamowienie.TabIndex = 36;
            this.btnNoweZamowienie.Text = "Stwórz nowe zamówienie";
            this.btnNoweZamowienie.UseVisualStyleBackColor = false;
            this.btnNoweZamowienie.Click += new System.EventHandler(this.btnNoweZamowienie_Click);
            // 
            // LblSumaZamowienia
            // 
            this.LblSumaZamowienia.AutoSize = true;
            this.LblSumaZamowienia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblSumaZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblSumaZamowienia.Location = new System.Drawing.Point(752, 431);
            this.LblSumaZamowienia.Name = "LblSumaZamowienia";
            this.LblSumaZamowienia.Size = new System.Drawing.Size(14, 16);
            this.LblSumaZamowienia.TabIndex = 35;
            this.LblSumaZamowienia.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(597, 432);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "Suma zamówienia w PLN";
            // 
            // btnWypozycz
            // 
            this.btnWypozycz.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnWypozycz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWypozycz.Location = new System.Drawing.Point(292, 584);
            this.btnWypozycz.Name = "btnWypozycz";
            this.btnWypozycz.Size = new System.Drawing.Size(171, 61);
            this.btnWypozycz.TabIndex = 33;
            this.btnWypozycz.Text = "Zatwierdź";
            this.btnWypozycz.UseVisualStyleBackColor = false;
            this.btnWypozycz.Click += new System.EventHandler(this.btnWypozycz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(295, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Czas wypożyczenia w dobach";
            // 
            // dropCzasWypozyczenia
            // 
            this.dropCzasWypozyczenia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropCzasWypozyczenia.FormattingEnabled = true;
            this.dropCzasWypozyczenia.Location = new System.Drawing.Point(292, 466);
            this.dropCzasWypozyczenia.Name = "dropCzasWypozyczenia";
            this.dropCzasWypozyczenia.Size = new System.Drawing.Size(171, 21);
            this.dropCzasWypozyczenia.TabIndex = 31;
            // 
            // btnUsunZzamowienia
            // 
            this.btnUsunZzamowienia.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsunZzamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsunZzamowienia.Location = new System.Drawing.Point(507, 265);
            this.btnUsunZzamowienia.Name = "btnUsunZzamowienia";
            this.btnUsunZzamowienia.Size = new System.Drawing.Size(75, 23);
            this.btnUsunZzamowienia.TabIndex = 30;
            this.btnUsunZzamowienia.Text = "<<<";
            this.btnUsunZzamowienia.UseVisualStyleBackColor = false;
            this.btnUsunZzamowienia.Click += new System.EventHandler(this.btnUsunZzamowienia_Click);
            // 
            // btnDodajDoZamowienia
            // 
            this.btnDodajDoZamowienia.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDodajDoZamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajDoZamowienia.Location = new System.Drawing.Point(507, 218);
            this.btnDodajDoZamowienia.Name = "btnDodajDoZamowienia";
            this.btnDodajDoZamowienia.Size = new System.Drawing.Size(75, 23);
            this.btnDodajDoZamowienia.TabIndex = 29;
            this.btnDodajDoZamowienia.Text = ">>>";
            this.btnDodajDoZamowienia.UseVisualStyleBackColor = false;
            this.btnDodajDoZamowienia.Click += new System.EventHandler(this.btnDodajDoZamowienia_Click);
            // 
            // dgvWorek
            // 
            this.dgvWorek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorek.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvWorek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorek.Location = new System.Drawing.Point(600, 84);
            this.dgvWorek.Name = "dgvWorek";
            this.dgvWorek.RowHeadersVisible = false;
            this.dgvWorek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorek.Size = new System.Drawing.Size(479, 332);
            this.dgvWorek.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Wybierz kategorię sprzętu";
            // 
            // dropKategorie
            // 
            this.dropKategorie.BackColor = System.Drawing.Color.AliceBlue;
            this.dropKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropKategorie.FormattingEnabled = true;
            this.dropKategorie.Location = new System.Drawing.Point(12, 35);
            this.dropKategorie.Name = "dropKategorie";
            this.dropKategorie.Size = new System.Drawing.Size(176, 21);
            this.dropKategorie.TabIndex = 26;
            this.dropKategorie.SelectedIndexChanged += new System.EventHandler(this.dropKategorie_SelectedIndexChanged);
            this.dropKategorie.SelectedValueChanged += new System.EventHandler(this.dropKategorie_SelectedValueChanged);
            // 
            // dgvWyborSprzetu
            // 
            this.dgvWyborSprzetu.AllowUserToAddRows = false;
            this.dgvWyborSprzetu.AllowUserToDeleteRows = false;
            this.dgvWyborSprzetu.AllowUserToResizeColumns = false;
            this.dgvWyborSprzetu.AllowUserToResizeRows = false;
            this.dgvWyborSprzetu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWyborSprzetu.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvWyborSprzetu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWyborSprzetu.Location = new System.Drawing.Point(12, 84);
            this.dgvWyborSprzetu.Name = "dgvWyborSprzetu";
            this.dgvWyborSprzetu.RowHeadersVisible = false;
            this.dgvWyborSprzetu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWyborSprzetu.Size = new System.Drawing.Size(479, 332);
            this.dgvWyborSprzetu.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(14, 607);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nr kontaktowy";
            // 
            // txtNrKontaktowy
            // 
            this.txtNrKontaktowy.Location = new System.Drawing.Point(12, 625);
            this.txtNrKontaktowy.Name = "txtNrKontaktowy";
            this.txtNrKontaktowy.Size = new System.Drawing.Size(171, 20);
            this.txtNrKontaktowy.TabIndex = 23;
            this.txtNrKontaktowy.TextChanged += new System.EventHandler(this.txtNrKontaktowy_TextChanged);
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPesel.Location = new System.Drawing.Point(14, 554);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(38, 15);
            this.lblPesel.TabIndex = 22;
            this.lblPesel.Text = "Pesel";
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(12, 572);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(171, 20);
            this.txtPesel.TabIndex = 21;
            this.txtPesel.TextChanged += new System.EventHandler(this.txtPesel_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(14, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nazwisko";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(12, 518);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(171, 20);
            this.txtNazwisko.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(14, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Imię";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(12, 466);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(171, 20);
            this.txtImie.TabIndex = 17;
            // 
            // formPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1126, 770);
            this.Controls.Add(this.tabControl1);
            this.Name = "formPracownik";
            this.Text = "Panel pracownika";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPracownik_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formPracownik_FormClosed);
            this.Load += new System.EventHandler(this.formPracownik_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorekZamP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktywneZamP)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPolkaDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRegalDodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynP)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWyborSprzetu)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvAktywneZamP;
        private System.Windows.Forms.DataGridView dgvWorekZamP;
        private System.Windows.Forms.Button btnUsunZamowienie;
        private System.Windows.Forms.Button btnRozlicz;
        private System.Windows.Forms.Button btnWypozycz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dropCzasWypozyczenia;
        private System.Windows.Forms.Button btnUsunZzamowienia;
        private System.Windows.Forms.Button btnDodajDoZamowienia;
        private System.Windows.Forms.DataGridView dgvWorek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dropKategorie;
        private System.Windows.Forms.DataGridView dgvWyborSprzetu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNrKontaktowy;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtRozmiarDodaj;
        private System.Windows.Forms.TextBox txtNazwaDodaj;
        private System.Windows.Forms.NumericUpDown numPolkaDodaj;
        private System.Windows.Forms.NumericUpDown numRegalDodaj;
        private System.Windows.Forms.TextBox txtWyszukajAktywne;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCzyscSzukanie;
        private System.Windows.Forms.Button btnWydaj;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numCena;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LblSumaZamowienia;
        private System.Windows.Forms.Button btnNoweZamowienie;
    }
}