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
using POO3A2038.DAL;

namespace POO3A2038.UI
{
    public partial class frmCadastrarLogin : Form
    {
        public frmCadastrarLogin()
        {
            InitializeComponent();
        }

        DALMVC bd = new DALMVC();
        string sql;

        public void Limpar()
        {
            txt_CadastrarLogin.Clear();
            txt_CadastraSenha.Clear();

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            try
            {
                tblClienteDTO objCliente = new tblClienteDTO();
                objCliente.Login = txt_CadastrarLogin.Text.Trim();
                objCliente.Senha = txt_CadastraSenha.Text.Trim();


                    sql = string.Format("insert into TBL_Login values('{0}','{1}')"
                        , txt_CadastrarLogin.Text, txt_CadastraSenha.Text);

                    bd.AlterarTabelas(sql);

                    MessageBox.Show("Cadastrado com sucesso!!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btn_Voltar_Click_1(object sender, EventArgs e)
        {
            FrmLogin dados = new FrmLogin();
            dados.Show();
            this.Close();
        }
    }
}
