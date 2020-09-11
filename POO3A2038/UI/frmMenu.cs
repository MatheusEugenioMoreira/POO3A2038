using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO3A2038.UI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_Musica_Click(object sender, EventArgs e)
        {
            frmMusica dados = new frmMusica();
            dados.ShowDialog();
            this.Visible = true;
            this.Hide();
        }

        private void btn_Gravadora_Click(object sender, EventArgs e)
        {
            frmGravadora dados = new frmGravadora();
            dados.ShowDialog();
            this.Visible = true;
            this.Hide();

        }

        
    }
}
