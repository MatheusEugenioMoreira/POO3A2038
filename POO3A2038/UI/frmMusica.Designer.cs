namespace POO3A2038.UI
{
    partial class frmMusica
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
            this.dgv_listar_musica = new System.Windows.Forms.DataGridView();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.pnl_Musica = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idCd = new System.Windows.Forms.TextBox();
            this.txt_idG = new System.Windows.Forms.TextBox();
            this.txt_NomeA = new System.Windows.Forms.TextBox();
            this.txt_NomeM = new System.Windows.Forms.TextBox();
            this.txt_idM = new System.Windows.Forms.TextBox();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar_musica)).BeginInit();
            this.pnl_Musica.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_listar_musica
            // 
            this.dgv_listar_musica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listar_musica.Location = new System.Drawing.Point(572, 3);
            this.dgv_listar_musica.Name = "dgv_listar_musica";
            this.dgv_listar_musica.Size = new System.Drawing.Size(651, 387);
            this.dgv_listar_musica.TabIndex = 0;
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
            // pnl_Musica
            // 
            this.pnl_Musica.Controls.Add(this.btn_Buscar);
            this.pnl_Musica.Controls.Add(this.label5);
            this.pnl_Musica.Controls.Add(this.label4);
            this.pnl_Musica.Controls.Add(this.label3);
            this.pnl_Musica.Controls.Add(this.label2);
            this.pnl_Musica.Controls.Add(this.label1);
            this.pnl_Musica.Controls.Add(this.txt_idCd);
            this.pnl_Musica.Controls.Add(this.txt_idG);
            this.pnl_Musica.Controls.Add(this.txt_NomeA);
            this.pnl_Musica.Controls.Add(this.txt_NomeM);
            this.pnl_Musica.Controls.Add(this.txt_idM);
            this.pnl_Musica.Controls.Add(this.btn_Alterar);
            this.pnl_Musica.Controls.Add(this.btn_Excluir);
            this.pnl_Musica.Controls.Add(this.btn_Adicionar);
            this.pnl_Musica.Controls.Add(this.dgv_listar_musica);
            this.pnl_Musica.Location = new System.Drawing.Point(12, 33);
            this.pnl_Musica.Name = "pnl_Musica";
            this.pnl_Musica.Size = new System.Drawing.Size(1226, 393);
            this.pnl_Musica.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Id CD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Id Gravadora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nome Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id Música:";
            // 
            // txt_idCd
            // 
            this.txt_idCd.Location = new System.Drawing.Point(308, 343);
            this.txt_idCd.Name = "txt_idCd";
            this.txt_idCd.Size = new System.Drawing.Size(174, 20);
            this.txt_idCd.TabIndex = 23;
            // 
            // txt_idG
            // 
            this.txt_idG.Location = new System.Drawing.Point(308, 283);
            this.txt_idG.Name = "txt_idG";
            this.txt_idG.Size = new System.Drawing.Size(174, 20);
            this.txt_idG.TabIndex = 22;
            // 
            // txt_NomeA
            // 
            this.txt_NomeA.Location = new System.Drawing.Point(308, 223);
            this.txt_NomeA.Name = "txt_NomeA";
            this.txt_NomeA.Size = new System.Drawing.Size(174, 20);
            this.txt_NomeA.TabIndex = 21;
            // 
            // txt_NomeM
            // 
            this.txt_NomeM.Location = new System.Drawing.Point(308, 163);
            this.txt_NomeM.Name = "txt_NomeM";
            this.txt_NomeM.Size = new System.Drawing.Size(174, 20);
            this.txt_NomeM.TabIndex = 20;
            // 
            // txt_idM
            // 
            this.txt_idM.Location = new System.Drawing.Point(308, 103);
            this.txt_idM.Name = "txt_idM";
            this.txt_idM.Size = new System.Drawing.Size(174, 20);
            this.txt_idM.TabIndex = 19;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar.Location = new System.Drawing.Point(12, 4);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(159, 23);
            this.btn_Voltar.TabIndex = 17;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(58, 225);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(147, 48);
            this.btn_Buscar.TabIndex = 29;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // frmMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1246, 432);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.pnl_Musica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Música";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar_musica)).EndInit();
            this.pnl_Musica.ResumeLayout(false);
            this.pnl_Musica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_listar_musica;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Panel pnl_Musica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idCd;
        private System.Windows.Forms.TextBox txt_idG;
        private System.Windows.Forms.TextBox txt_NomeA;
        private System.Windows.Forms.TextBox txt_NomeM;
        private System.Windows.Forms.TextBox txt_idM;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Buscar;
    }
}