using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO3A2038.DAL;
using POO3A2038.DTO;

namespace POO3A2038.UI
{
    public partial class frmGravadora : Form
    {
        public frmGravadora()
        {
            InitializeComponent();
            dgv_listar_Gravadora.DataSource = bd.ConsultarDadosTabela("SELECT * from TBL_Gravadora");
        }

        DALMVC bd = new DALMVC();
        string sql;

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frmMenu dados = new frmMenu();
            dados.Show();
            this.Close();
        }

        public void Limpar()
        {
            txt_idG.Clear();
            txt_nomeG.Clear();
            
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                tblClienteDTO objCliente = new tblClienteDTO();
                objCliente.NomeGravadora = txt_nomeG.Text.Trim();
                


                if (txt_idG.Text != "")
                {
                    MessageBox.Show("Deixe o campo 'Id Gravadora' vazio, ele será gerado automaticamente");
                }
                else
                {

                    sql = string.Format("insert into TBL_Gravadora values(null,'{1}')"
                        , txt_idG.Text, txt_nomeG.Text);

                    bd.AlterarTabelas(sql);

                    MessageBox.Show("Música cadastrada com sucesso!!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    dgv_listar_Gravadora.DataSource = bd.ConsultarDadosTabela("SELECT * from TBL_Gravadora");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_lista_usu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idG.Text = dgv_listar_Gravadora.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nomeG.Text = dgv_listar_Gravadora.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update TBL_Gravadora set nome = '{0}' where idGravadora = '{1}'"
                , txt_nomeG.Text, txt_idG.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Gravadora alterada com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            dgv_listar_Gravadora.DataSource = bd.ConsultarDadosTabela("SELECT * from TBL_Gravadora");
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from TBL_Gravadora where idGravadora = '{0}'", txt_idG.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Música excluida com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            dgv_listar_Gravadora.DataSource = bd.ConsultarDadosTabela("SELECT * from TBL_Gravadora");
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();

            sql = string.Format("select * from TBL_Gravadora where idGravadora = '{0}'", txt_idG.Text);
            buscar = bd.ConsultarDadosTabela(sql);

            if (buscar.Rows.Count > 0)
            {
                txt_nomeG.Text = buscar.Rows[0]["nome"].ToString();
                
            }
            else
            {
                MessageBox.Show("Gravadora não cadastrado!!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
