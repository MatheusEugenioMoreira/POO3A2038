using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO3A2038.DTO;
using POO3A2038.BLL;
using POO3A2038.UI;



namespace POO3A2038
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            try 
            {
                tblClienteDTO objCliente = new tblClienteDTO();
                objCliente.Login = txt_Login.Text.Trim();
                objCliente.Senha = txt_Senha.Text.Trim();
                this.Visible = false;

                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.Autenticar(objCliente.Login, objCliente.Senha))
                {
                    MessageBox.Show("Usuário Localizado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMenu dados = new frmMenu();
                    dados.ShowDialog();
                    this.Visible = true;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário Não Localizado", "Falho!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            frmCadastrarLogin dados = new frmCadastrarLogin();
            dados.ShowDialog();
            this.Visible = true;
            this.Hide();
        }
    }
}
