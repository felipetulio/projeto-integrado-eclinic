using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Collections;


namespace Projeto_Integrado
{
    public class clsPaciente
    {
        private int codigo;
        private string nome;
        private string endereco;
        private string rg;
        private int cpf;
        private string datanasc;
        private int idade;
        private string sexo;
        private string telefone;
        private string email;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome 
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string RG
        {
            get { return rg; }
            set { rg = value; }
        }

        public int CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string DataNasc
        {
            get { return datanasc; }
            set { datanasc = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void SalvarPaciente()
        {
            //Prevenção contra sql injection
            string sql = "INSERT INTO pacientes VALUES(null, @nome, @endereco, @rg, @cpf, @datanasc, @idade, @sexo, @telefone, @email);";
            MySqlCommand commS = new MySqlCommand(sql, DBclass.mConn);
            
            // adiciona-se o parametro, indicando o nome e o tipo
            commS.Parameters.Add("@nome", MySqlDbType.VarChar);
            // atribui-se o respectivo valor
            commS.Parameters["@nome"].Value = nome;

            commS.Parameters.Add("@endereco", MySqlDbType.VarChar);
            commS.Parameters["@endereco"].Value = endereco;

            commS.Parameters.Add("@rg", MySqlDbType.VarChar);
            commS.Parameters["@rg"].Value = rg;

            commS.Parameters.Add("@cpf", MySqlDbType.Int16);
            commS.Parameters["@cpf"].Value = cpf;

            commS.Parameters.Add("@datanasc", MySqlDbType.VarChar);
            commS.Parameters["@datanasc"].Value = datanasc;

            commS.Parameters.Add("@idade", MySqlDbType.Int16);
            commS.Parameters["@idade"].Value = idade;

            commS.Parameters.Add("@sexo", MySqlDbType.VarChar);
            commS.Parameters["@sexo"].Value = sexo;

            commS.Parameters.Add("@telefone", MySqlDbType.VarChar);
            commS.Parameters["@telefone"].Value = telefone;

            commS.Parameters.Add("@email", MySqlDbType.VarChar);
            commS.Parameters["@email"].Value = email;

            try
            {
                DBclass.ExecuteNonQuery(commS);
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        
    }
}
