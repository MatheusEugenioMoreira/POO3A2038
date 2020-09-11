using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POO3A2038.DTO
{
    class tblClienteDTO
    {

        private string login, senha;
        private int idGravadora, idCD, idMusica;
        private string nomeGravadora, nomeCD, nomeMusica, nomeAutor; 
        private double precoVenda;
        

        
        

        
        
        public int IdGravadora
        {
            set
            {
                if( value != 0)
                {
                    this.idGravadora = value;
                }
                else
                {
                    throw new Exception("O campo idGravadora é obrigatório");
                }
            }
            get
            {
                return this.idGravadora;
            }
        }

        public int IdCD
        {
            set
            {
                if (value != 0)
                {
                    this.idCD = value;
                }
                else
                {
                    throw new Exception("O campo Id CD é obrigatório");
                }
            }
            get
            {
                return this.idCD;
            }
        }

        public int IdMusica
        {
            set
            {
                if (value != 0)
                {
                    this.idMusica = value;
                }
                else
                {
                    throw new Exception("O campo Id Musica é obrigatório");
                }
            }
            get
            {
                return this.idMusica;
            }
        }


        public string Login
        {
            set
            {
                if ( value != string.Empty)
                {
                    this.login = value;
                }
                else
                {
                    throw new Exception("O campo login é obrigatório");
                }
            }

            get
            {
                return this.login;
            }
        }

        public string Senha
        {
            set
            {
                if ( value != string.Empty )
                {
                    this.senha = value;
                }
                else
                {
                    throw new Exception("O campo senha é obrigatório");
                }
            }

            get
            {
                return this.senha;
            }
        }

        public string NomeGravadora {
            set
            {
                if ( value != string.Empty)
                {
                    this.nomeGravadora = value;
                }
                else
                {
                    throw new Exception("O campo Nome Gravadora é obrigatório");
                }
            }

            get
            {
                return this.nomeGravadora;
            }
        }

        public string NomeCD
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeCD = value;
                }
                else
                {
                    throw new Exception("O campo Nome CD é obrigatório");
                }
            }

            get
            {
                return this.nomeCD;
            }
        }

        public string NomeMusica
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeMusica = value;
                }
                else
                {
                    throw new Exception("O campo Nome Música é obrigatório");
                }
            }

            get
            {
                return this.nomeMusica;
            }
        }

        public string NomeAutor
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeAutor = value;
                }
                else
                {
                    throw new Exception("O campo Nome Autor é obrigatório");
                }
            }

            get
            {
                return this.nomeAutor;
            }
        }

        public double PrecoVenda
        {
            set
            {
                if (value != 0)
                {
                    this.precoVenda = value;
                }
                else
                {
                    throw new Exception("O campo iPreço é obrigatório");
                }
            }
            get
            {
                return this.precoVenda;
            }
        }

        
    }
}
