namespace WindowsFormsApp1
{
    partial class Disk_Helper
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.searchItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(651, 630);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(344, 125);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "ricerca";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.search_button_Click);
            // 
            // searchItem
            // 
            this.searchItem.Location = new System.Drawing.Point(651, 341);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(374, 31);
            this.searchItem.TabIndex = 1;
            this.searchItem.TextChanged += new System.EventHandler(this.searchItem_TextChanged);
            // 
            // Disk_Helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 885);
            this.Controls.Add(this.searchItem);
            this.Controls.Add(this.searchButton);
            this.Name = "Disk_Helper";
            this.Text = "Disk Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchItem;
    }
}

