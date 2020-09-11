using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO3A2038.DAL;
using System.Data;

namespace POO3A2038.BLL
{
    class tblClienteBLL
    {
        private DALMVC daoBanco = new DALMVC();

        public Boolean Autenticar(string login, string senha)
        {
            string consulta = string.Format($@"select * from tbl_login where login = '{login}' and senha ='{senha}';");
            DataTable dt = daoBanco.ConsultarDadosTabela(consulta);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
