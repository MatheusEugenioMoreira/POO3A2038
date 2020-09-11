namespace POO3A2038.UI
{
    partial class frmMenu
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
            this.btn_Musica = new System.Windows.Forms.Button();
            this.btn_Gravadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Musica
            // 
            this.btn_Musica.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Musica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Musica.Location = new System.Drawing.Point(41, 34);
            this.btn_Musica.Name = "btn_Musica";
            this.btn_Musica.Size = new System.Drawing.Size(128, 45);
            this.btn_Musica.TabIndex = 0;
            this.btn_Musica.Text = "Música";
            this.btn_Musica.UseVisualStyleBackColor = false;
            this.btn_Musica.Click += new System.EventHandler(this.btn_Musica_Click);
            // 
            // btn_Gravadora
            // 
            this.btn_Gravadora.BackColor = System.Drawing.Color.Orange;
            this.btn_Gravadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gravadora.Location = new System.Drawing.Point(41, 155);
            this.btn_Gravadora.Name = "btn_Gravadora";
            this.btn_Gravadora.Size = new System.Drawing.Size(128, 45);
            this.btn_Gravadora.TabIndex = 1;
            this.btn_Gravadora.Text = "Gravadora";
            this.btn_Gravadora.UseVisualStyleBackColor = false;
            this.btn_Gravadora.Click += new System.EventHandler(this.btn_Gravadora_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(205, 251);
            this.Controls.Add(this.btn_Gravadora);
            this.Controls.Add(this.btn_Musica);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Musica;
        private System.Windows.Forms.Button btn_Gravadora;
    }
}