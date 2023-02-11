namespace Wypozyczalnia
{
    partial class formWybor
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
            this.btnModKlienta = new System.Windows.Forms.Button();
            this.btnModPracownika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModKlienta
            // 
            this.btnModKlienta.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModKlienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModKlienta.Location = new System.Drawing.Point(71, 57);
            this.btnModKlienta.Name = "btnModKlienta";
            this.btnModKlienta.Size = new System.Drawing.Size(190, 84);
            this.btnModKlienta.TabIndex = 0;
            this.btnModKlienta.Text = "Moduł klienta";
            this.btnModKlienta.UseVisualStyleBackColor = false;
            this.btnModKlienta.Click += new System.EventHandler(this.btnModKlienta_Click);
            // 
            // btnModPracownika
            // 
            this.btnModPracownika.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModPracownika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModPracownika.Location = new System.Drawing.Point(71, 176);
            this.btnModPracownika.Name = "btnModPracownika";
            this.btnModPracownika.Size = new System.Drawing.Size(190, 84);
            this.btnModPracownika.TabIndex = 1;
            this.btnModPracownika.Text = "Moduł pracownika";
            this.btnModPracownika.UseVisualStyleBackColor = false;
            this.btnModPracownika.Click += new System.EventHandler(this.btnModPracownika_Click);
            // 
            // formWybor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(326, 312);
            this.Controls.Add(this.btnModPracownika);
            this.Controls.Add(this.btnModKlienta);
            this.Name = "formWybor";
            this.Text = "Panel główny";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formWybor_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModKlienta;
        private System.Windows.Forms.Button btnModPracownika;
    }
}