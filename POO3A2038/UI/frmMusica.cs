using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO3A2038.BLL;
using POO3A2038.DAL;
using POO3A2038.DTO;

namespace POO3A2038.UI
{
    public partial class frmMusica : Form
    {
        public frmMusica()
        {
            InitializeComponent();
            dgv_listar_musica.DataSource = bd.ConsultarDadosTabela("SELECT * from TBL_Musica");
        }

        DALMVC bd = new DALMVC();
        string sql;

        public void Limpar()
        {
            txt_idM.Clear();
            txt_NomeM.Clear();
            txt_NomeA.Clear();
            txt_idG.Clear();
            txt_idCd.Clear();
        }

        


        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                tblClienteDTO objCliente = new tblClienteDTO();
                objCliente.NomeMusica = txt_NomeM.Text.Trim();
                objCliente.NomeAutor = txt_NomeA.Text.Trim();
                


                if (txt_idM.Text != "")
                {
                    MessageBox.Show("Deixe o campo 'Id Música' vazio, ele será gerado automaticamente");
                }
                else
                {

                    sql = string.Format("insert into TBL_Musica values(null,'{1}','{2}','{3}','{4}')"
                        , txt_idM.Text, txt_NomeM.Text, txt_NomeA.Text, txt_idG.Text, txt_idCd.Text);

                    bd.AlterarTabelas(sql);

                    MessageBox.Show("Música cadastrada com sucesso!!", "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    dgv_listar_musica.DataSource = bd.ConsultarDadosTabela("SELECT * from TBL_Musica");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_lista_usu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idM.Text = dgv_listar_musica.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_NomeM.Text = dgv_listar_musica.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_NomeA.Text = dgv_listar_musica.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_idG.Text = dgv_listar_musica.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_idCd.Text = dgv_listar_musica.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update TBL_Musica set nome = '{0}', nomeAutor = '{1}' where idMusica = '{2}'"
                         , txt_NomeM.Text, txt_NomeA.Text, txt_idM.Text);
            bd.AlterarTabelas(sql);

            MessageBox.Show("Música Alterada com sucesso!!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            dgv_listar_musica.DataSource = bd.ConsultarDadosTabela("SELECT * from TBL_Musica");
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            sql = string.Format("delete from TBL_Musica where idMusica = '{0}'", txt_idM.Text);
            bd.AlterarTabelas(sql);
            MessageBox.Show("Música excluida com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            dgv_listar_musica.DataSource = bd.ConsultarDadosTabela("SELECT * from TBL_Musica");
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            frmMenu dados = new frmMenu();
            dados.Show();
            this.Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable buscar = new DataTable();

            sql = string.Format("select * from TBL_Musica where idMusica = '{0}'", txt_idM.Text);
            buscar = bd.ConsultarDadosTabela(sql);

            if ( buscar.Rows.Count > 0)
            {
                txt_NomeM.Text = buscar.Rows[0]["nome"].ToString();
                txt_NomeA.Text = buscar.Rows[0]["nomeAutor"].ToString();
                txt_idG.Text = buscar.Rows[0]["idGravadora"].ToString();
                txt_idCd.Text = buscar.Rows[0]["idCD"].ToString();
            }
            else
            {
                MessageBox.Show("Musica não cadastrado!!", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
