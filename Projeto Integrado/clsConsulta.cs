using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.DateTime;


namespace Projeto_Integrado
{
    public class clsConsulta
    {
        private DateTime dataconsulta;
        private string convenio;
        private string observacoes;
        private float valor;
        private int codpaciente;
        private string nomepaciente;
        private int codmedico;
        private string nomemedico;
        private string historico;

        public DateTime DataConsulta
        {
            get { return dataconsulta; }
            set { dataconsulta = value; }
        }

        public string Convenio
        {
            get { return convenio; }
            set { convenio = value; }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public int CodPaciente
        {
            get { return codpaciente; }
            set { codpaciente = value; }
        }

        public string NomePaciente
        {
            get { return nomepaciente; }
            set { nomepaciente = value; }
        }

        public int CodMedico
        {
            get { return codmedico; }
            set { codmedico = value; }
        }

        public string NomeMedico
        {
            get { return nomemedico; }
            set { nomemedico = value; }
        }

        public string Historico
        {
            get { return historico; }
            set { historico = value; }
        }
    }
}
