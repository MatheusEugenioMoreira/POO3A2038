namespace POO3A2038.UI
{
    partial class frmGravadora
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
            this.pnl_Gravadora = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nomeG = new System.Windows.Forms.TextBox();
            this.txt_idG = new System.Windows.Forms.TextBox();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.dgv_listar_Gravadora = new System.Windows.Forms.DataGridView();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.pnl_Gravadora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar_Gravadora)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Gravadora
            // 
            this.pnl_Gravadora.Controls.Add(this.btn_Buscar);
            this.pnl_Gravadora.Controls.Add(this.label9);
            this.pnl_Gravadora.Controls.Add(this.label10);
            this.pnl_Gravadora.Controls.Add(this.txt_nomeG);
            this.pnl_Gravadora.Controls.Add(this.txt_idG);
            this.pnl_Gravadora.Controls.Add(this.btn_Alterar);
            this.pnl_Gravadora.Controls.Add(this.btn_Excluir);
            this.pnl_Gravadora.Controls.Add(this.btn_Adicionar);
            this.pnl_Gravadora.Controls.Add(this.dgv_listar_Gravadora);
            this.pnl_Gravadora.Location = new System.Drawing.Point(12, 36);
            this.pnl_Gravadora.Name = "pnl_Gravadora";
            this.pnl_Gravadora.Size = new System.Drawing.Size(1226, 393);
            this.pnl_Gravadora.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(305, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(304, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Id Gravadora:";
            // 
            // txt_nomeG
            // 
            this.txt_nomeG.Location = new System.Drawing.Point(308, 163);
            this.txt_nomeG.Name = "txt_nomeG";
            this.txt_nomeG.Size = new System.Drawing.Size(174, 20);
            this.txt_nomeG.TabIndex = 20;
            // 
            // txt_idG
            // 
            this.txt_idG.Location = new System.Drawing.Point(308, 103);
            this.txt_idG.Name = "txt_idG";
            this.txt_idG.Size = new System.Drawing.Size(174, 20);
            this.txt_idG.TabIndex = 19;
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Location = new System.Drawing.Point(58, 148);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(147, 48);
            this.btn_Alterar.TabIndex = 18;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.Red;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Location = new System.Drawing.Point(58, 313);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(147, 48);
            this.btn_Excluir.TabIndex = 17;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.BackColor = System.Drawing.Color.Green;
            this.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Adicionar.Location = new System.Drawing.Point(58, 73);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(147, 48);
            this.btn_Adicionar.TabIndex = 15;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = false;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // dgv_listar_Gravadora
            // 
            this.dgv_listar_Gravadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listar_Gravadora.Location = new System.Drawing.Point(572, 3);
            this.dgv_listar_Gravadora.Name = "dgv_listar_Gravadora";
            this.dgv_listar_Gravadora.Size = new System.Drawing.Size(651, 387);
            this.dgv_listar_Gravadora.TabIndex = 0;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar.Location = new System.Drawing.Point(12, 7);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(159, 23);
            this.btn_Voltar.TabIndex = 31;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(58, 232);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(147, 48);
            this.btn_Buscar.TabIndex = 30;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // frmGravadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1246, 432);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.pnl_Gravadora);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGravadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGravadora";
            this.pnl_Gravadora.ResumeLayout(false);
            this.pnl_Gravadora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar_Gravadora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Gravadora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nomeG;
        private System.Windows.Forms.TextBox txt_idG;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.DataGridView dgv_listar_Gravadora;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Buscar;
    }
}