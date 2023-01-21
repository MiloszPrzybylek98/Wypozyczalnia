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
            this.btnModKlienta.Location = new System.Drawing.Point(167, 204);
            this.btnModKlienta.Name = "btnModKlienta";
            this.btnModKlienta.Size = new System.Drawing.Size(190, 84);
            this.btnModKlienta.TabIndex = 0;
            this.btnModKlienta.Text = "Moduł klienta";
            this.btnModKlienta.UseVisualStyleBackColor = true;
            // 
            // btnModPracownika
            // 
            this.btnModPracownika.Location = new System.Drawing.Point(424, 204);
            this.btnModPracownika.Name = "btnModPracownika";
            this.btnModPracownika.Size = new System.Drawing.Size(166, 84);
            this.btnModPracownika.TabIndex = 1;
            this.btnModPracownika.Text = "Moduł pracownika";
            this.btnModPracownika.UseVisualStyleBackColor = true;
            // 
            // formWybor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModPracownika);
            this.Controls.Add(this.btnModKlienta);
            this.Name = "formWybor";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModKlienta;
        private System.Windows.Forms.Button btnModPracownika;
    }
}