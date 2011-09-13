using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Projeto_Integrado
{
   public class clsTecnico
    {
        private string nome;
        private string endereco;
        private string rg;
        private int cpf;
        private string telefone;
        private string email;
        private string crm;
        private string especialidade;
        private string atendimento;

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

        public string CRM
        {
            get { return crm; }
            set { crm = value; }
        }

        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }

        public string Atendimento
        {
            get { return atendimento; }
            set { atendimento = value; }
        }

        public void SalvarTecnico()
        {
            //Prevenção contra sql injection
            string sql = "INSERT INTO tecnicos VALUES(null, @nome, @endereco, @rg, @cpf, @telefone, @email, @crm, @especialidade, @atendimento);";
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

            commS.Parameters.Add("@telefone", MySqlDbType.VarChar);
            commS.Parameters["@telefone"].Value = telefone;

            commS.Parameters.Add("@email", MySqlDbType.VarChar);
            commS.Parameters["@email"].Value = email;

            commS.Parameters.Add("@crm", MySqlDbType.VarChar);
            commS.Parameters["@crm"].Value = crm;

            commS.Parameters.Add("@especialidade", MySqlDbType.VarChar);
            commS.Parameters["@especialidade"].Value = especialidade;

            commS.Parameters.Add("@atendimento", MySqlDbType.VarChar);
            commS.Parameters["@atendimento"].Value = atendimento;


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
